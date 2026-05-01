using SDX.AbilitySystem.Resources.Windup;
using SDX.AbilitySystem.Core.Context;

namespace SDX.AbilitySystem.Core.Execution.Recover
{
    public abstract partial class AbilityRecoverHandler : IAbilityRecoverHandler
    {
        protected readonly IAbilityRecoverContext Context;
        protected readonly AbilityExecutionBlackboard Blackboard;

        protected AbilityRecoverHandler(IAbilityRecoverContext context, AbilityExecutionBlackboard blackboard)
        {
            Context = context;
            Blackboard = blackboard;
        }

        public abstract void Setup(AbilityWindup data);
        public abstract void Recover();
        public abstract void Cancel();
    }
}
