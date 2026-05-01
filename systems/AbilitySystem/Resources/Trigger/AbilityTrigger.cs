using Godot;
using SDX.AbilitySystem.Core.Execution.Execute.Trigger;

namespace SDX.AbilitySystem.Resources.Trigger
{
    [GlobalClass]
    public abstract partial class AbilityTrigger : Resource, IAbilityTrigger
    {
        public abstract IAbilityExecuteTriggerHandler CreateHandler(object blackboard);
    }
}
