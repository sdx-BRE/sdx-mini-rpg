using Godot;
using Godot.Collections;

namespace SDX.AbilitySystem.Resources.Delivery.Damage
{
    [GlobalClass]
    public partial class AbilityDamage : Resource
    {
        [Export] public Array<AbilityDamageModifier> Modifiers { get; set; } = new Array<AbilityDamageModifier>();
        [Export] public bool PlayHitAnimation { get; set; } = true;
    }
}
