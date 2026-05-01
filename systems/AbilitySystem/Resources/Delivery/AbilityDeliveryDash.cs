using Godot;
using SDX.AbilitySystem.Core.Execution.Execute.Delivery;

namespace SDX.AbilitySystem.Resources.Delivery
{
    [GlobalClass]
    public partial class AbilityDeliveryDash : AbilityDelivery
    {
        [Export] public float DashPower { get; set; } = 15.0f;

        public override IAbilityExecuteDeliveryHandler CreateHandler(object context, object blackboard)
        {
            return new DummyDeliveryHandler(context, blackboard);
        }
    }
}
