class_name DirectionalTargetMarker extends Node3D

@onready var _mesh: MeshInstance3D = $MeshInstance3D

func set_charge_amount(amount: float) -> void:
	# amount is expected to be 0.0 to 1.0
	_mesh.get_material_override().set_shader_parameter(&"charge_amount", amount)
