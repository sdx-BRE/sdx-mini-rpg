using Godot;
using SDX.AbilitySystem.Core.Execution.Execute.Trigger;
using SDX.AbilitySystem.Core.Execution;
using SDX.AbilitySystem.Core.Context;

namespace SDX.AbilitySystem.Resources.Trigger
{
    [GlobalClass]
    public partial class AbilityTriggerChanneled : AbilityTrigger
    {
        public override IAbilityExecuteTriggerHandler CreateHandler(IAbilityExecuteContext context, AbilityExecutionBlackboard blackboard)
        {
            return new DummyTriggerHandler(context, blackboard);
        }
    }
}
