using Godot;

namespace SDX.AbilitySystem.Resources
{
    [GlobalClass]
    public partial class AbilityCooldown : Resource
    {
        public enum CooldownType { Internal, External }

        [Export] public CooldownType Type { get; set; } = CooldownType.Internal;
        [Export] public float Duration { get; set; } = 0.0f;
    }
}
