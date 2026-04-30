class_name AbilityTargetingAIDirectional extends AbilityTargeting

@export var aim_speed: float = 2.0
@export var lock_on_time: float = 2.0
@export var max_aim_time: float = 10.0
@export var lock_on_dot_threshold: float = 0.8

func get_strategy(context: AbilityAimingContext) -> AbilityAimingHandler:
	return AbilityAimingAIDirectionalHandler.new(context)
