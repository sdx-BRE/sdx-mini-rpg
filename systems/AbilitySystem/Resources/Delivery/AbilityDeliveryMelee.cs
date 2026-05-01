using Godot;
using Godot.Collections;
using SDX.AbilitySystem.Core.Execution.Execute.Delivery;
using SDX.AbilitySystem.Core.Execution;
using SDX.AbilitySystem.Core.Context;
using SDX.AbilitySystem.Resources.Delivery.Damage;

namespace SDX.AbilitySystem.Resources.Delivery
{
    [GlobalClass]
    public partial class AbilityDeliveryMelee : AbilityDelivery
    {
        [Export] public AbilityDamage Damage { get; set; }
        [Export] public Array<PackedScene> HitEffects { get; set; }

        public override IAbilityExecuteDeliveryHandler CreateHandler(IAbilityExecuteContext context, AbilityExecutionBlackboard blackboard)
        {
            return new DummyDeliveryHandler(context, blackboard);
        }
    }
}