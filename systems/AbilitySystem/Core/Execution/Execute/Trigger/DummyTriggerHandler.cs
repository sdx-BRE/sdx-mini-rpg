using SDX.AbilitySystem.Core.Context;
using SDX.AbilitySystem.Resources.Trigger;

namespace SDX.AbilitySystem.Core.Execution.Execute.Trigger
{
    public partial class DummyTriggerHandler : AbilityExecuteTriggerHandler
    {
        public DummyTriggerHandler(IAbilityExecuteContext context, AbilityExecutionBlackboard blackboard) 
            : base(context, blackboard) { }

        public override void Setup(AbilityTrigger data) { }
        public override void Start() { }
        public override void Tick(float delta) { }
        public override void Trigger() { }
        public override void Release() { }
        public override void Cancel() { }
    }
}
