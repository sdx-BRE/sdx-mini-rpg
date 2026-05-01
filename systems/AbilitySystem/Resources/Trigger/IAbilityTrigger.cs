using SDX.AbilitySystem.Core.Execution.Execute.Trigger;
using SDX.AbilitySystem.Core.Execution;
using SDX.AbilitySystem.Core.Context;

namespace SDX.AbilitySystem.Resources.Trigger
{
    public interface IAbilityTrigger
    {
        IAbilityExecuteTriggerHandler CreateHandler(IAbilityExecuteContext context, AbilityExecutionBlackboard blackboard);
    }
}
