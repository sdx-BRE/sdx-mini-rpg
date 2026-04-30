using Godot;
using SDX.AbilitySystem.Resources.Targeting;
using SDX.AbilitySystem.Resources.Trigger;
using SDX.AbilitySystem.Resources.Windup;
using SDX.AbilitySystem.Resources.Delivery;

namespace SDX.AbilitySystem.Resources
{
    [GlobalClass]
    public partial class AbilityData : Resource
    {
        [Export] public AbilityCooldown Cooldown { get; set; } = new();
        [Export] public AbilityCost Cost { get; set; } = new();
        [Export] public AbilityTargeting Targeting { get; set; }
        [Export] public AbilityTrigger Trigger { get; set; }
        [Export] public AbilityWindup Windup { get; set; }
        [Export] public AbilityDelivery Delivery { get; set; }

        [Export] public string Id { get; set; } = "";
        
        // Custom input action handling would go here, 
        // for now keeping it as a simple property to match GDScript's intent.
        [Export] public string Input { get; set; } = "";

        [Export] public bool Debug { get; set; } = false;
    }
}
