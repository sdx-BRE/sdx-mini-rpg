using SDX.AbilitySystem.Core.Execution.Execute.Trigger;

namespace SDX.AbilitySystem.Resources.Trigger
{
    public interface IAbilityTrigger
    {
        IAbilityExecuteTriggerHandler CreateHandler(object blackboard);
    }
}
