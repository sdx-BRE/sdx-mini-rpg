using Godot;
using SDX.Damage.Payloads;

namespace SDX.AbilitySystem.Resources.Delivery.Damage
{
    [GlobalClass]
    public abstract partial class AbilityDamageModifier : Resource
    {
        public abstract DamagePayload ToPayload();
    }
}
