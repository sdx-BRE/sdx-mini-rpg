using System;
using SDX.AbilitySystem.Resources.Trigger;

namespace SDX.AbilitySystem.Core.Execution.Execute.Trigger
{
    public partial class DummyTriggerHandler : IAbilityExecuteTriggerHandler
    {
        public event Action Triggered;
        public event Action<float> TriggeredTick;
        public event Action Finished;

        private readonly object _blackboard;

        public DummyTriggerHandler(object blackboard)
        {
            _blackboard = blackboard;
        }

        public void Setup(AbilityTrigger data) { }
        public void Start() { }
        public void Tick(float delta) { }
        public void Release() { }
        public void Cancel() { }
    }
}
