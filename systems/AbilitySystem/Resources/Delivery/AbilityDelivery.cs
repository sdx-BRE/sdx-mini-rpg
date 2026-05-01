using Godot;
using SDX.AbilitySystem.Core.Execution.Execute.Delivery;
using SDX.AbilitySystem.Core.Execution;
using SDX.AbilitySystem.Core.Context;

namespace SDX.AbilitySystem.Resources.Delivery
{
    [GlobalClass]
    public abstract partial class AbilityDelivery : Resource, IAbilityDelivery
    {
        public abstract IAbilityExecuteDeliveryHandler CreateHandler(IAbilityExecuteContext context, AbilityExecutionBlackboard blackboard);
    }
}
