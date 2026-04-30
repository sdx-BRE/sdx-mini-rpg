class_name DamageHitbox extends Area3D

func take_damage(hit: DamageInstance) -> void:
	if get_parent().has_method("take_damage"):
		get_parent().take_damage(hit)
	else:
		push_error("[ERROR][DamageHitbox.take_damage()] - could not delegate damage to entity!")

func get_target_point() -> Node3D:
	if get_parent().has_method("get_target_point"):
		return get_parent().get_target_point()
	
	return self
