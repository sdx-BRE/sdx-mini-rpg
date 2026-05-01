using SDX.AbilitySystem.Resources.Windup;
using SDX.AbilitySystem.Core.Context;

namespace SDX.AbilitySystem.Core.Execution.Recover
{
    public partial class DummyRecoverHandler : AbilityRecoverHandler
    {
        public DummyRecoverHandler(IAbilityRecoverContext context, AbilityExecutionBlackboard blackboard) 
            : base(context, blackboard) { }

        public override void Setup(AbilityWindup data) { }
        public override void Recover() { }
        public override void Cancel() { }
    }
}
