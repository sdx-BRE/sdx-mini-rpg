using Godot;
using SDX.AbilitySystem.Core.Execution.Aiming;

namespace SDX.AbilitySystem.Resources.Targeting
{
    [GlobalClass]
    public partial class AbilityTargetingSelf : AbilityTargeting
    {
        public override IAbilityAimingHandler CreateHandler(IAbilityAimingContext context)
        {
            return new DummyAimingHandler(context);
        }
    }
}
