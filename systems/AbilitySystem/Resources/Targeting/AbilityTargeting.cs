using Godot;
using SDX.AbilitySystem.Core.Execution.Aiming;
using SDX.AbilitySystem.Core.Execution;
using SDX.AbilitySystem.Core.Context;

namespace SDX.AbilitySystem.Resources.Targeting
{
    [GlobalClass]
    public abstract partial class AbilityTargeting : Resource, IAbilityTargeting
    {
        public abstract IAbilityAimingHandler CreateHandler(IAbilityAimingContext context, AbilityExecutionBlackboard blackboard);
    }
}
