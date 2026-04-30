class_name DamagePayloadCurrentHealthPercent extends DamagePayload

var percent: float = 0.0

func _init(_percent: float) -> void:
	percent = _percent

func get_immediate_damage(stats: EntityStats) -> float:
	return stats.get_health() * percent
