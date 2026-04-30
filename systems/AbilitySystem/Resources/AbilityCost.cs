using Godot;

namespace SDX.AbilitySystem.Resources
{
    [GlobalClass]
    public partial class AbilityCost : Resource
    {
        public enum CostType { Instant, Tick, External }

        [Export] public CostType Type { get; set; } = CostType.External;
        [Export] public float Mana { get; set; } = 0.0f;
        [Export] public float Stamina { get; set; } = 0.0f;
    }
}
