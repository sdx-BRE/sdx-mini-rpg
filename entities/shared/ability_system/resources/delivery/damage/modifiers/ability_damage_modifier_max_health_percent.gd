class_name AbilityDamageModifierMaxHealthPercent extends AbilityDamageModifier

@export_range(0.0, 1.0) var percent: float = 0.1

func to_payload() -> DamagePayload:
	return DamagePayloadMaxHealthPercent.new(percent)
