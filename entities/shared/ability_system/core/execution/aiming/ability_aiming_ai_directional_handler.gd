class_name AbilityAimingAIDirectionalHandler extends AbilityAimingHandler

var _data: AbilityTargetingAIDirectional
var _handler: AiTargetHandler
var _current_aim_time: float = 0.0
var _lock_timer: float = 0.0
var _yaw: float = 0.0

func setup(data: AbilityTargeting) -> void:
	_data = data as AbilityTargetingAIDirectional
	_handler = _context.get_ai_target_handler()
	_context.show_directional_marker()
	
	# Initialize yaw from current direction
	var origin_pos := _context.get_origin_position()
	var target_pos := _handler.get_target_position()
	var diff := target_pos - origin_pos
	
	if not Vector2(diff.x, diff.z).is_zero_approx():
		_yaw = atan2(-diff.x, -diff.z)
	
	_context.set_aim_yaw(_yaw)

func tick(delta: float) -> void:
	_current_aim_time += delta
	
	if _current_aim_time >= _data.max_aim_time:
		_complete_aiming()
		return
	
	_update_rotation(delta)
	
	if _is_locked_on():
		_lock_timer += delta
		var charge := clampf(_lock_timer / _data.lock_on_time, 0.0, 1.0)
		_context.set_aim_charge(charge)
		
		if _lock_timer >= _data.lock_on_time:
			_complete_aiming()
	else:
		_lock_timer = 0.0
		var charge := clampf(_current_aim_time / _data.max_aim_time, 0.0, 1.0)
		_context.set_aim_charge(charge)

func _update_rotation(delta: float) -> void:
	var target_pos := _handler.get_target_position()
	var origin_pos := _context.get_origin_position()
	var diff := target_pos - origin_pos
	
	if Vector2(diff.x, diff.z).is_zero_approx():
		return
	
	var target_yaw := atan2(-diff.x, -diff.z)
	
	_yaw = lerp_angle(_yaw, target_yaw, _data.aim_speed * delta)
	_context.set_aim_yaw(_yaw)

func _is_locked_on() -> bool:
	var target_pos := _handler.get_target_position()
	var origin_pos := _context.get_origin_position()
	var diff := (target_pos - origin_pos)
	var horizontal_diff := Vector2(diff.x, diff.z)
	
	if horizontal_diff.is_zero_approx():
		return true
		
	var target_dir := horizontal_diff.normalized()
	
	# Our current forward vector based on _yaw (assuming -Z is forward)
	var forward := Vector2(-sin(_yaw), -cos(_yaw))
	
	return forward.dot(target_dir) >= _data.lock_on_dot_threshold

func _complete_aiming() -> void:
	_context.set_aim_charge(0.0)
	_context.hide_directional_marker()
	_emit_target_aquired(AbilityAimingAIDirectionalResult.new(_handler, _yaw))

func cancel() -> void:
	_context.set_aim_charge(0.0)
	_context.hide_directional_marker()
