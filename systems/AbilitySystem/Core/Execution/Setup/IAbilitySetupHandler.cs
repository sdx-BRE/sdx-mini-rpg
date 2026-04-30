using System;
using Godot;
using SDX.AbilitySystem.Resources.Windup;

namespace SDX.AbilitySystem.Core.Execution.Setup
{
    public interface IAbilitySetupHandler
    {
        event Action VisualReady;

        void Setup(AbilityWindup data);
        void Start();
        void Tick(float delta);
        void Trigger();
        void HitEvent(Node3D target);
        void Cancel();
    }
}
