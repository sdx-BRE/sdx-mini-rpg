using Godot;
using SDX.AbilitySystem.Core.Execution.Aiming;

namespace SDX.AbilitySystem.Resources.Targeting
{
    [GlobalClass]
    public abstract partial class AbilityTargeting : Resource, IAbilityTargeting
    {
        public abstract IAbilityAimingHandler CreateHandler(IAbilityAimingContext context);
    }
}
