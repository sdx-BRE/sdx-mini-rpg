using System;
using SDX.AbilitySystem.Resources.Trigger;
using SDX.AbilitySystem.Core.Context;

namespace SDX.AbilitySystem.Core.Execution.Execute.Trigger
{
    public abstract partial class AbilityExecuteTriggerHandler : IAbilityExecuteTriggerHandler
    {
        public event Action Triggered;
        public event Action<float> TriggeredTick;
        public event Action Finished;

        protected readonly IAbilityExecuteContext Context;
        protected readonly AbilityExecutionBlackboard Blackboard;

        protected AbilityExecuteTriggerHandler(IAbilityExecuteContext context, AbilityExecutionBlackboard blackboard)
        {
            Context = context;
            Blackboard = blackboard;
        }

        public abstract void Setup(AbilityTrigger data);
        public abstract void Start();
        public abstract void Tick(float delta);
        public abstract void Trigger();
        public abstract void Release();
        public abstract void Cancel();

        protected void EmitTriggered() => Triggered?.Invoke();
        protected void EmitTriggeredTick(float delta) => TriggeredTick?.Invoke(delta);
        protected void EmitFinished() => Finished?.Invoke();
    }
}
