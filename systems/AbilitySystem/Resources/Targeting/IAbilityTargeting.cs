using SDX.AbilitySystem.Core.Execution.Aiming;
using SDX.AbilitySystem.Core.Execution;
using SDX.AbilitySystem.Core.Context;

namespace SDX.AbilitySystem.Resources.Targeting
{
    public interface IAbilityTargeting
    {
        IAbilityAimingHandler CreateHandler(IAbilityAimingContext context, AbilityExecutionBlackboard blackboard);
    }
}
