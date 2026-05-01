using SDX.AbilitySystem.Core.Execution.Setup;
using SDX.AbilitySystem.Core.Execution.Recover;
using SDX.AbilitySystem.Core.Execution;
using SDX.AbilitySystem.Core.Context;

namespace SDX.AbilitySystem.Resources.Windup
{
    public interface IAbilityWindup
    {
        IAbilitySetupHandler CreateHandler(IAbilitySetupContext context, AbilityExecutionBlackboard blackboard);
        IAbilityRecoverHandler CreateRecoverHandler(IAbilityRecoverContext context, AbilityExecutionBlackboard blackboard);
    }
}
