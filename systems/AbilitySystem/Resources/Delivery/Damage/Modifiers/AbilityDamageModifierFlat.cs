using Godot;
using SDX.Damage.Payloads;

namespace SDX.AbilitySystem.Resources.Delivery.Damage.Modifiers
{
    [GlobalClass]
    public partial class AbilityDamageModifierFlat : AbilityDamageModifier
    {
        [Export] public float Damage { get; set; } = 10.0f;

        public override DamagePayload ToPayload()
        {
            return new DamagePayloadFlat(Damage);
        }
    }
}
