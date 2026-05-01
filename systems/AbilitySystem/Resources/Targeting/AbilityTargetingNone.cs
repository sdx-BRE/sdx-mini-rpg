using Godot;
using SDX.AbilitySystem.Core.Execution.Aiming;
using SDX.AbilitySystem.Core.Execution;
using SDX.AbilitySystem.Core.Context;

namespace SDX.AbilitySystem.Resources.Targeting
{
    [GlobalClass]
    public partial class AbilityTargetingNone : AbilityTargeting
    {
        public override IAbilityAimingHandler CreateHandler(IAbilityAimingContext context, AbilityExecutionBlackboard blackboard)
        {
            return new DummyAimingHandler(context, blackboard);
        }
    }
}
