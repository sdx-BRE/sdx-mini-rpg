using Godot;
using Godot.Collections;
using SDX.AbilitySystem.Core.Execution.Execute.Delivery;

namespace SDX.AbilitySystem.Resources.Delivery
{
    [GlobalClass]
    public partial class AbilityDeliveryMelee : AbilityDelivery
    {
        [Export] public Resource Damage { get; set; } // TODO: Change to AbilityDamage once ported
        [Export] public Array<PackedScene> HitEffects { get; set; }

        public override IAbilityExecuteDeliveryHandler CreateHandler(object context, object blackboard)
        {
            return new DummyDeliveryHandler(context, blackboard);
        }
    }
}
