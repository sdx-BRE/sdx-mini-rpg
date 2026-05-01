using Godot;
using SDX.Damage.Payloads;

namespace SDX.AbilitySystem.Resources.Delivery.Damage.Modifiers
{
    [GlobalClass]
    public partial class AbilityDamageModifierDot : AbilityDamageModifier
    {
        [Export] public float Damage { get; set; } = 5.0f;
        [Export] public float Duration { get; set; } = 10.0f;
        [Export] public float Interval { get; set; } = 1.0f;

        public override DamagePayload ToPayload()
        {
            return new DamagePayloadDot(Damage, Duration, Interval);
        }
    }
}
