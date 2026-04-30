using Godot;
using System;

namespace SDX.Shared.Utils
{
    public static class AnimationUtil
    {
        public static float? TryGetCallMethodTrackTime(
            AnimationPlayer player, 
            StringName animName, 
            StringName callMethodTrackName)
        {
            if (player == null || !player.HasAnimation(animName))
            {
                GD.PrintErr($"[AnimationUtil::TryGetCallMethodTrackTime()] - animation '{animName}' not found on player {player?.Name}");
                return null;
            }

            var animation = player.GetAnimation(animName);
            
            for (int trackIdx = 0; trackIdx < animation.GetTrackCount(); trackIdx++)
            {
                if (animation.TrackGetType(trackIdx) == Animation.TrackType.Method)
                {
                    for (int keyIdx = 0; keyIdx < animation.TrackGetKeyCount(trackIdx); keyIdx++)
                    {
                        var methodData = animation.TrackGetKeyValue(trackIdx, keyIdx).As<Godot.Collections.Dictionary>();
                        
                        if (methodData.ContainsKey("method") && methodData["method"].AsStringName() == callMethodTrackName)
                        {
                            return (float)animation.TrackGetKeyTime(trackIdx, keyIdx);
                        }
                    }
                }
            }
            
            return null;
        }
    }
}
