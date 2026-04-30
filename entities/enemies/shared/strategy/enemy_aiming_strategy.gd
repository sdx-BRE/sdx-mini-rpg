class_name EnemyAimingStrategy extends AbilityAimingStrategy

var _handler: AiTargetHandler
var _marker: Node3D

func _init(handler: AiTargetHandler, marker: Node3D) -> void:
	_handler = handler
	_marker = marker

func get_ai_target_handler() -> AiTargetHandler:
	return _handler

func show_directional_marker() -> void:
	_marker.show()

func hide_directional_marker() -> void:
	_marker.hide()

func set_aim_yaw(angle: float) -> void:
	_marker.global_rotation.y = angle

func set_aim_charge(amount: float) -> void:
	_marker.set_charge_amount(amount)

func get_origin_position() -> Vector3:
	return _marker.global_position
