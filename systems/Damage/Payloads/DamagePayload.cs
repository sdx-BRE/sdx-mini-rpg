using SDX.Stats;

namespace SDX.Damage.Payloads
{
    public interface IDamagePayload
    {
        float GetImmediateDamage(IEntityStats stats);
        IDebuff GetDebuff(IEntityStats stats);
    }

    public abstract partial class DamagePayload : Godot.RefCounted, IDamagePayload
    {
        public abstract float GetImmediateDamage(IEntityStats stats);
        public abstract IDebuff GetDebuff(IEntityStats stats);
    }
}
