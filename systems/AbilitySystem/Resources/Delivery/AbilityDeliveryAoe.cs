using Godot;
using SDX.AbilitySystem.Core.Execution.Execute.Delivery;
using SDX.AbilitySystem.Core.Execution;
using SDX.AbilitySystem.Core.Context;

namespace SDX.AbilitySystem.Resources.Delivery
{
    [GlobalClass]
    public partial class AbilityDeliveryAoe : AbilityDelivery
    {
        [Export] public PackedScene Scene { get; set; }
        [Export] public Resource Damage { get; set; } // TODO: Change to AbilityDamage once ported
        [Export] public float Delay { get; set; } = 0.75f;
        [Export] public float Radius { get; set; } = 2.0f;

        public override IAbilityExecuteDeliveryHandler CreateHandler(IAbilityExecuteContext context, AbilityExecutionBlackboard blackboard)
        {
            return new DummyDeliveryHandler(context, blackboard);
        }
    }
}
