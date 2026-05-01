using Godot;
using SDX.Damage.Payloads;

namespace SDX.AbilitySystem.Resources.Delivery.Damage.Modifiers
{
    [GlobalClass]
    public partial class AbilityDamageModifierMaxHealthPercent : AbilityDamageModifier
    {
        [Export] public float Percent { get; set; } = 10.0f;

        public override DamagePayload ToPayload()
        {
            return new DamagePayloadMaxHealthPercent(Percent);
        }
    }
}
