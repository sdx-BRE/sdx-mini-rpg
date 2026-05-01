using System;
using Godot;
using SDX.AbilitySystem.Resources.Windup;
using SDX.AbilitySystem.Core.Context;

namespace SDX.AbilitySystem.Core.Execution.Setup
{
    public abstract partial class AbilitySetupHandler : IAbilitySetupHandler
    {
        public event Action VisualReady;

        protected readonly IAbilitySetupContext Context;
        protected readonly AbilityExecutionBlackboard Blackboard;

        protected AbilitySetupHandler(IAbilitySetupContext context, AbilityExecutionBlackboard blackboard)
        {
            Context = context;
            Blackboard = blackboard;
        }

        public abstract void Setup(AbilityWindup data);
        public abstract void Start();
        public abstract void Tick(float delta);
        public abstract void Trigger();
        public abstract void HitEvent(Node3D target);
        public abstract void Cancel();

        protected void EmitVisualReady() => VisualReady?.Invoke();
    }
}
