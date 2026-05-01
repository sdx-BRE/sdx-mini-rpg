using Godot;
using SDX.AbilitySystem.Resources.Targeting;

namespace SDX.AbilitySystem.Core.Execution.Aiming
{
    public abstract partial class AbilityAimingHandler : IAbilityAimingHandler
    {
        protected readonly IAbilityAimingContext Context;

        protected AbilityAimingHandler(IAbilityAimingContext context)
        {
            Context = context;
        }

        public abstract void Setup(AbilityTargeting data);
        public abstract object HandleInput(InputEvent @event);
        public abstract void Tick(float delta);
        public abstract void Cancel();
    }
}
