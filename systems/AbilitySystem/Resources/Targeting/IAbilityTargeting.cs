using SDX.AbilitySystem.Core.Execution.Aiming;

namespace SDX.AbilitySystem.Resources.Targeting
{
    public interface IAbilityTargeting
    {
        IAbilityAimingHandler CreateHandler(IAbilityAimingContext context);
    }
}
