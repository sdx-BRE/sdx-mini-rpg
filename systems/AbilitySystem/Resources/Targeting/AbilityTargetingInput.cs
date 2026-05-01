using Godot;
using SDX.AbilitySystem.Core.Execution.Aiming;

namespace SDX.AbilitySystem.Resources.Targeting
{
    [GlobalClass]
    public abstract partial class AbilityTargetingInput : AbilityTargeting
    {
        [Export] public float CastRange { get; set; }
        [Export(PropertyHint.Enum, "attack,skill_1,skill_2,skill_3")]
        public string InputTrigger { get; set; } = "attack";
    }
}
