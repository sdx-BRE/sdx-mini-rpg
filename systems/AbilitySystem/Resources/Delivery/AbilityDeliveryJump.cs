using Godot;
using SDX.AbilitySystem.Core.Execution.Execute.Delivery;

namespace SDX.AbilitySystem.Resources.Delivery
{
    [GlobalClass]
    public partial class AbilityDeliveryJump : AbilityDelivery
    {
        public override IAbilityExecuteDeliveryHandler CreateHandler(object context, object blackboard)
        {
            return new DummyDeliveryHandler(context, blackboard);
        }
    }
}
