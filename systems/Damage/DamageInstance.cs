using Godot;
using Godot.Collections;
using SDX.Damage.Payloads;
using SDX.AbilitySystem.Resources.Delivery.Damage;

namespace SDX.Damage
{
    [GlobalClass]
    public partial class DamageInstance : RefCounted
    {
        private readonly Array<DamagePayload> _payloads = new Array<DamagePayload>();
        private readonly bool _triggerHitAnimation = true;

        public DamageInstance() { }

        public DamageInstance(Array<DamagePayload> payloads, bool triggerHitAnimation = true)
        {
            _payloads = payloads;
            _triggerHitAnimation = triggerHitAnimation;
        }

        public static DamageInstance FromAbility(AbilityDamage abilityDamage)
        {
            if (abilityDamage == null) return new DamageInstance();

            var mappedPayloads = new Array<DamagePayload>();
            foreach (var modifier in abilityDamage.Modifiers)
            {
                var payload = modifier.ToPayload();
                if (payload != null)
                {
                    mappedPayloads.Add(payload);
                }
            }

            return new DamageInstance(mappedPayloads, abilityDamage.PlayHitAnimation);
        }

        public Array<DamagePayload> GetPayloads() => _payloads;
        public bool ShouldTriggerHitAnimation() => _triggerHitAnimation;
    }
}
