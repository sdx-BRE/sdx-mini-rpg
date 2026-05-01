using Godot;
using SDX.AbilitySystem.Core.Execution.Execute.Delivery;
using SDX.AbilitySystem.Core.Execution;
using SDX.AbilitySystem.Core.Context;

namespace SDX.AbilitySystem.Resources.Delivery
{
    [GlobalClass]
    public partial class AbilityDeliveryProjectile : AbilityDelivery
    {
        public enum HomingType
        {
            Disabled,
            Simple,
            Predictive
        }

        [Export] public PackedScene Scene { get; set; }
        
        [ExportGroup("Projectile Stats")]
        [Export] public Resource Damage { get; set; } // TODO: Change to AbilityDamage once ported
        [Export] public float Speed { get; set; } = 15.0f;
        [Export] public float Lifetime { get; set; } = 3.0f;

        [ExportGroup("Homing")]
        [Export] public HomingType Homing { get; set; } = HomingType.Disabled;
        [Export(PropertyHint.Range, "-1,1")] public float HomingFov { get; set; } = -0.5f;
        [Export] public float HomingSteerSpeed { get; set; } = 2.0f;

        public override IAbilityExecuteDeliveryHandler CreateHandler(IAbilityExecuteContext context, AbilityExecutionBlackboard blackboard)
        {
            return new DummyDeliveryHandler(context, blackboard);
        }
    }
}
