using SDX.Stats;

namespace SDX.Damage.Payloads
{
    public partial class DamagePayloadDot : DamagePayload
    {
        private readonly float _damage;
        private readonly float _duration;
        private readonly float _interval;

        public DamagePayloadDot(float damage, float duration, float interval)
        {
            _damage = damage;
            _duration = duration;
            _interval = interval;
        }

        public override float GetImmediateDamage(IEntityStats stats)
        {
            return 0.0f;
        }

        public override IDebuff GetDebuff(IEntityStats stats)
        {
            return null;
        }

        public float GetDamage() => _damage;
        public float GetDuration() => _duration;
        public float GetInterval() => _interval;
    }
}
