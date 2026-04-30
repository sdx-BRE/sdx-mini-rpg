class_name AbilityAimingAIDirectionalResult extends AbilityAimingResult

var _handler: AiTargetHandler
var _yaw: float

func _init(handler: AiTargetHandler, yaw: float) -> void:
	_handler = handler
	_yaw = yaw

func set_projectile_target(projectile: BaseProjectile, _context: AbilityExecuteContext) -> void:
	var target := _handler.get_target()
	if target is DamageHitbox:
		projectile._target = target.entity
	else:
		projectile._target = target

func launch_projectile(projectile: BaseProjectile, context: AbilityExecuteContext) -> void:
	projectile.global_basis = _get_launch_basis(context.get_pivot_basis())

func launch_aoe(aoe: BaseAoe, context: AbilityExecuteContext) -> void:
	aoe.global_basis = _get_launch_basis(context.get_pivot_basis())

func _get_launch_basis(_default_basis: Basis = Basis.IDENTITY) -> Basis:
	# _yaw is the angle to rotate Vector3.FORWARD to face the target
	var basis := Basis.IDENTITY
	basis = basis.rotated(Vector3.UP, _yaw)
	return basis
