using Godot;
using SDX.AbilitySystem.Core.Execution.Execute.Trigger;
using SDX.AbilitySystem.Core.Execution;
using SDX.AbilitySystem.Core.Context;

namespace SDX.AbilitySystem.Resources.Trigger
{
    [GlobalClass]
    public abstract partial class AbilityTrigger : Resource, IAbilityTrigger
    {
        public abstract IAbilityExecuteTriggerHandler CreateHandler(IAbilityExecuteContext context, AbilityExecutionBlackboard blackboard);
    }
}
