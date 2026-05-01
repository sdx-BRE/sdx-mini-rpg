using Godot;
using SDX.AbilitySystem.Core.Execution.Aiming;
using SDX.AbilitySystem.Core.Execution;
using SDX.AbilitySystem.Core.Context;

namespace SDX.AbilitySystem.Resources.Targeting
{
    [GlobalClass]
    public partial class AbilityTargetingAIDirectional : AbilityTargeting
    {
        [Export] public float AimSpeed { get; set; } = 5.0f;
        [Export] public float LockOnTime { get; set; } = 0.5f;

        public override IAbilityAimingHandler CreateHandler(IAbilityAimingContext context, AbilityExecutionBlackboard blackboard)
        {
            return new DummyAimingHandler(context, blackboard);
        }
    }
}
