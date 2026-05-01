using Godot;
using SDX.AbilitySystem.Core.Execution.Setup;
using SDX.AbilitySystem.Core.Execution.Recover;
using SDX.AbilitySystem.Core.Execution;
using SDX.AbilitySystem.Core.Context;

namespace SDX.AbilitySystem.Resources.Windup
{
    [GlobalClass]
    public abstract partial class AbilityWindup : Resource, IAbilityWindup
    {
        public abstract IAbilitySetupHandler CreateHandler(IAbilitySetupContext context, AbilityExecutionBlackboard blackboard);
        public abstract IAbilityRecoverHandler CreateRecoverHandler(IAbilityRecoverContext context, AbilityExecutionBlackboard blackboard);
    }
}
