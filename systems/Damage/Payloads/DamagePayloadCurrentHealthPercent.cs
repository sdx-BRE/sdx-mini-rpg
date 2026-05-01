using Godot;
using SDX.Stats;

namespace SDX.Damage.Payloads
{
    public partial class DamagePayloadCurrentHealthPercent : DamagePayload
    {
        private readonly float _percent;

        public DamagePayloadCurrentHealthPercent(float percent)
        {
            _percent = percent;
        }

        public override float GetImmediateDamage(IEntityStats stats)
        {
            if (stats == null) return 0.0f;
            return stats.CurrentHealth * (_percent / 100.0f);
        }

        public override IDebuff GetDebuff(IEntityStats stats)
        {
            return null;
        }
    }
}
