using SDX.AbilitySystem.Core.Execution.Setup;
using SDX.AbilitySystem.Core.Execution.Recover;

namespace SDX.AbilitySystem.Resources.Windup
{
    public interface IAbilityWindup
    {
        IAbilitySetupHandler CreateSetupHandler(object context, object blackboard);
        IAbilityRecoverHandler CreateRecoverHandler(object context);
    }
}
