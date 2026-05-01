using Godot;
using SDX.AbilitySystem.Resources.Targeting;

namespace SDX.AbilitySystem.Core.Execution.Aiming
{
    public interface IAbilityAimingHandler
    {
        void Setup(AbilityTargeting data);
        object HandleInput(InputEvent @event);
        void Tick(float delta);
        void Cancel();
    }
}
