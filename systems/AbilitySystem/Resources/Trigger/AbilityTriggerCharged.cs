using Godot;
using SDX.AbilitySystem.Core.Execution.Trigger;

namespace SDX.AbilitySystem.Resources.Trigger
{
    [GlobalClass]
    public partial class AbilityTriggerCharged : AbilityTrigger
    {
        public override IAbilityExecuteTriggerHandler CreateHandler(object blackboard)
        {
            return new DummyTriggerHandler(blackboard);
        }
    }
}
