using Godot;
using SDX.AbilitySystem.Core.Execution.Aiming;

namespace SDX.AbilitySystem.Resources.Targeting
{
    [GlobalClass]
    public partial class AbilityTargetingDirectional : AbilityTargetingInput
    {
        public override IAbilityAimingHandler CreateHandler(IAbilityAimingContext context)
        {
            return new DummyAimingHandler(context);
        }
    }
}
