using Godot;
using SDX.AbilitySystem.Core.Execution.Execute.Delivery;

namespace SDX.AbilitySystem.Resources.Delivery
{
    [GlobalClass]
    public abstract partial class AbilityDelivery : Resource, IAbilityDelivery
    {
        public abstract IAbilityExecuteDeliveryHandler CreateHandler(object context, object blackboard);
    }
}
