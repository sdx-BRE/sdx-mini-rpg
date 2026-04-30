class_name AbilityAimingDirectionalHandler extends AbilityAimingHandler

var _data: AbilityTargetingDirectional
var _yaw: float = 0.0
var _pitch: float = 0.0

func setup(data: AbilityTargeting) -> void:
	_data = data as AbilityTargetingDirectional
	_context.show_directional_marker()
	_context.use_visible_mouse()

func tick(_delta: float) -> void:
	var ray_result := _context.raycast_from_mouse(1000.0, Layers.COLLISION_WORLD)
	
	if ray_result.is_empty():
		return
	
	var target_pos: Vector3 = ray_result.position
	var player_pos: Vector3 = _context.get_origin_position()
	
	var diff := target_pos - player_pos
	
	_yaw = atan2(-diff.x, -diff.z)
	
	var horizontal_dist := Vector2(diff.x, diff.z).length()
	_pitch = atan2(diff.y, horizontal_dist)
	
	_context.set_aim_yaw(_yaw)
	_context.set_aim_pitch(_pitch)

func handle_input(event: InputEvent) -> AbilityHandleInputResult:
	if event.is_action_pressed("ui_cancel"):
		_cleanup_ui_state()
		_emit_cancel()
		return AbilityHandleInputResult.handled(&"ui_cancel")
		
	if event.is_action_pressed(_data.input_trigger):
		var targets := _find_targets()
		_cleanup_ui_state()
		_emit_target_aquired(AbilityAimingResultDirectional.new(_yaw, _pitch, targets))
		return AbilityHandleInputResult.handled(_data.input_trigger)
	
	return AbilityHandleInputResult.unhandled()

func cancel() -> void:
	_cleanup_ui_state()

func _find_targets() -> Array[Node3D]:
	var origin := _context.get_origin_position()
	var basis := Basis.IDENTITY
	basis = basis.rotated(Vector3.UP, _yaw)
	basis = basis.rotated(basis.x, _pitch)
	
	var forward := -basis.z
	var right := basis.x
	
	var ray_range := _data.cast_range
	if ray_range <= 0:
		ray_range = 100.0
	
	var targets: Array[Node3D] = []
	
	var offsets: Array[float] = [-1.0, -0.5, 0.0, 0.5, 1.0]
	for offset in offsets:
		var ray_dir: Vector3 = (forward + right * offset * 0.1).normalized()
		var ray_end: Vector3 = origin + ray_dir * ray_range
		
		var result := _context.raycast(origin, ray_end)
		
		if not result.is_empty():
			var collider = result.collider
			if collider is Node3D and not targets.has(collider):
				targets.append(collider)
				
	return targets

func _cleanup_ui_state() -> void:
	_context.hide_directional_marker()
	_context.use_captured_mouse()
