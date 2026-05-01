using Godot;
using SDX.Damage.Payloads;

namespace SDX.AbilitySystem.Resources.Delivery.Damage.Modifiers
{
    [GlobalClass]
    public partial class AbilityDamageModifierCurrentHealthPercent : AbilityDamageModifier
    {
        [Export] public float Percent { get; set; } = 10.0f;

        public override DamagePayload ToPayload()
        {
            return new DamagePayloadCurrentHealthPercent(Percent);
        }
    }
}
