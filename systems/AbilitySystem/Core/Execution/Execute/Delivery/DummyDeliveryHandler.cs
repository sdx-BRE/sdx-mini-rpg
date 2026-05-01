using SDX.AbilitySystem.Core.Context;
using SDX.AbilitySystem.Resources.Delivery;

namespace SDX.AbilitySystem.Core.Execution.Execute.Delivery
{
    public partial class DummyDeliveryHandler : AbilityExecuteDeliveryHandler
    {
        public DummyDeliveryHandler(IAbilityExecuteContext context, AbilityExecutionBlackboard blackboard) 
            : base(context, blackboard) { }

        public override void Setup(AbilityDelivery data) { }
        public override void Execute(object aimingResult) { }
        public override void Release() { }
        public override void Cancel() { }
    }
}
