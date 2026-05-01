using Godot;
using SDX.AbilitySystem.Core.Execution.Execute.Delivery;
using SDX.AbilitySystem.Core.Execution;
using SDX.AbilitySystem.Core.Context;

namespace SDX.AbilitySystem.Resources.Delivery
{
    [GlobalClass]
    public partial class AbilityDeliveryBuff : AbilityDelivery
    {
        [Export] public PackedScene Scene { get; set; }
        [Export] public float Duration { get; set; }

        public override IAbilityExecuteDeliveryHandler CreateHandler(IAbilityExecuteContext context, AbilityExecutionBlackboard blackboard)
        {
            return new DummyDeliveryHandler(context, blackboard);
        }
    }
}
