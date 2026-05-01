using Godot;

namespace SDX.Damage
{
    [GlobalClass]
    public partial class DamageHitbox : Area3D
    {
        public void TakeDamage(DamageInstance hit)
        {
            Node parent = GetParent();
            if (parent != null && parent.HasMethod("take_damage"))
            {
                parent.Call("take_damage", hit);
            }
            else
            {
                GD.PushError("[ERROR][DamageHitbox.TakeDamage()] - could not delegate damage to entity!");
            }
        }

        public Node3D GetTargetPoint()
        {
            Node parent = GetParent();
            if (parent != null && parent.HasMethod("get_target_point"))
            {
                return (Node3D)parent.Call("get_target_point");
            }

            return this;
        }
    }
}
