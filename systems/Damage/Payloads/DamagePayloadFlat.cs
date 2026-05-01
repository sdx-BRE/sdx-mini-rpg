using SDX.Stats;

namespace SDX.Damage.Payloads
{
    public partial class DamagePayloadFlat : DamagePayload
    {
        private readonly float _damage;

        public DamagePayloadFlat(float damage)
        {
            _damage = damage;
        }

        public override float GetImmediateDamage(IEntityStats stats)
        {
            return _damage;
        }

        public override IDebuff GetDebuff(IEntityStats stats)
        {
            return null;
        }
    }
}
