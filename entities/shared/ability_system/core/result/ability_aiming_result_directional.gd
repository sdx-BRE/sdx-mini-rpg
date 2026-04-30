class_name AbilityAimingResultDirectional extends AbilityAimingResult

var _yaw: float
var _pitch: float
var _targets: Array[Node3D]

func _init(yaw: float, pitch: float, targets: Array[Node3D] = []) -> void:
	_yaw = yaw
	_pitch = pitch
	_targets = targets

func set_projectile_target(projectile: BaseProjectile, _context: AbilityExecuteContext) -> void:
	if not _targets.is_empty():
		projectile._target = _targets[0]

func launch_projectile(projectile: BaseProjectile, context: AbilityExecuteContext) -> void:
	projectile.global_basis = _get_launch_basis(context.get_pivot_basis())

func launch_aoe(aoe: BaseAoe, context: AbilityExecuteContext) -> void:
	aoe.global_basis = _get_launch_basis(context.get_pivot_basis())

func _get_launch_basis(_default_basis: Basis = Basis.IDENTITY) -> Basis:
	var basis := Basis.IDENTITY
	basis = basis.rotated(Vector3.UP, _yaw)
	basis = basis.rotated(basis.x, _pitch)
	return basis
