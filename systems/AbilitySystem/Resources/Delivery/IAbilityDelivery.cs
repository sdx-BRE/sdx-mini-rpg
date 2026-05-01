using SDX.AbilitySystem.Core.Execution.Execute.Delivery;

namespace SDX.AbilitySystem.Resources.Delivery
{
    public interface IAbilityDelivery
    {
        IAbilityExecuteDeliveryHandler CreateHandler(object context, object blackboard);
    }
}
