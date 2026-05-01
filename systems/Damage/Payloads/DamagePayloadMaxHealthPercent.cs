using SDX.Stats;

namespace SDX.Damage.Payloads
{
    public partial class DamagePayloadMaxHealthPercent : DamagePayload
    {
        private readonly float _percent;

        public DamagePayloadMaxHealthPercent(float percent)
        {
            _percent = percent;
        }

        public override float GetImmediateDamage(IEntityStats stats)
        {
            if (stats == null) return 0.0f;
            return stats.MaxHealth * (_percent / 100.0f);
        }

        public override IDebuff GetDebuff(IEntityStats stats)
        {
            return null;
        }
    }
}
