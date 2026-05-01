using Godot;
using SDX.AbilitySystem.Core.Execution.Setup;
using SDX.AbilitySystem.Core.Execution.Recover;

namespace SDX.AbilitySystem.Resources.Windup
{
    [GlobalClass]
    public abstract partial class AbilityWindup : Resource, IAbilityWindup
    {
        public abstract IAbilitySetupHandler CreateSetupHandler(object context, object blackboard);
        public abstract IAbilityRecoverHandler CreateRecoverHandler(object context);
    }
}
