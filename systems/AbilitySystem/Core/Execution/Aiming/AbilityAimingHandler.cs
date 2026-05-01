using Godot;
using SDX.AbilitySystem.Resources.Targeting;
using SDX.AbilitySystem.Core.Context;

namespace SDX.AbilitySystem.Core.Execution.Aiming
{
    public abstract partial class AbilityAimingHandler : IAbilityAimingHandler
    {
        protected readonly IAbilityAimingContext Context;
        protected readonly AbilityExecutionBlackboard Blackboard;

        protected AbilityAimingHandler(IAbilityAimingContext context, AbilityExecutionBlackboard blackboard)
        {
            Context = context;
            Blackboard = blackboard;
        }

        public abstract void Setup(AbilityTargeting data);
        public abstract object HandleInput(InputEvent @event);
        public abstract void Tick(float delta);
        public abstract void Cancel();
    }
}
