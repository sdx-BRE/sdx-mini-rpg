namespace SDX.AbilitySystem.Core.Execution.Execute.Delivery
{
    public partial class DummyDeliveryHandler : AbilityExecuteDeliveryHandler
    {
        public DummyDeliveryHandler(object context, object blackboard) : base(context, blackboard) { }

        public override void Setup(SDX.AbilitySystem.Resources.Delivery.AbilityDelivery data) { }
        public override void Execute(object aimingResult) { }
        public override void Release() { }
        public override void Cancel() { }
    }
}
