using Godot;
using SDX.AbilitySystem.Core.Execution.Trigger;

namespace SDX.AbilitySystem.Resources.Trigger
{
    public interface IAbilityTrigger
    {
        IAbilityExecuteTriggerHandler CreateHandler(object blackboard);
    }

    [GlobalClass]
    public abstract partial class AbilityTrigger : Resource, IAbilityTrigger
    {
        public abstract IAbilityExecuteTriggerHandler CreateHandler(object blackboard);
    }
}
