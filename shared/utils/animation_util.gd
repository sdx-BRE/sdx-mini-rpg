class_name AnimationUtil extends RefCounted

static func try_get_call_method_track_time(
	player: AnimationPlayer, 
	anim_name: StringName, 
	call_method_track_name: StringName,
):
	var animation := player.get_animation(anim_name)
	
	if animation == null:
		push_error("[AnimationUtil::try_get_call_method_track_time()] - animation not found")
		return null
	
	for track_idx in animation.get_track_count():
		if animation.track_get_type(track_idx) == Animation.TYPE_METHOD:
			for key_idx in animation.track_get_key_count(track_idx):
				var method = animation.track_get_key_value(track_idx, key_idx)
				
				if method["method"] == call_method_track_name:
					return animation.track_get_key_time(track_idx, key_idx)
	
	return null
