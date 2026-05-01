using Godot;
using SDX.AbilitySystem.Core.Execution.Aiming;

namespace SDX.AbilitySystem.Resources.Targeting
{
    [GlobalClass]
    public partial class AbilityTargetingAIDirectional : AbilityTargeting
    {
        [Export] public float AimSpeed { get; set; } = 2.0f;
        [Export] public float LockOnTime { get; set; } = 2.0f;
        [Export] public float MaxAimTime { get; set; } = 10.0f;
        [Export] public float LockOnDotThreshold { get; set; } = 0.8f;

        public override IAbilityAimingHandler CreateHandler(IAbilityAimingContext context)
        {
            return new DummyAimingHandler(context);
        }
    }
}
