using Godot;
using SDX.AbilitySystem.Core.Execution.Aiming;
using SDX.AbilitySystem.Core.Execution;
using SDX.AbilitySystem.Core.Context;

namespace SDX.AbilitySystem.Resources.Targeting
{
    [GlobalClass]
    public partial class AbilityTargetingLocation : AbilityTargeting
    {
        [Export] public float CastRange { get; set; } = 10.0f;

        public override IAbilityAimingHandler CreateHandler(IAbilityAimingContext context, AbilityExecutionBlackboard blackboard)
        {
            return new DummyAimingHandler(context, blackboard);
        }
    }
}
