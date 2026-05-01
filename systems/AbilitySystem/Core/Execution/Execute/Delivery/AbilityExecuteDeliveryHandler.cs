using System;
using SDX.AbilitySystem.Resources.Delivery;

namespace SDX.AbilitySystem.Core.Execution.Execute.Delivery
{
    public abstract partial class AbilityExecuteDeliveryHandler : IAbilityExecuteDeliveryHandler
    {
        public event Action CostRequired;
        public event Action<float> ContinuousCostRequired;

        protected readonly object Context;
        protected readonly object Blackboard;

        protected AbilityExecuteDeliveryHandler(object context, object blackboard)
        {
            Context = context;
            Blackboard = blackboard;
        }

        public abstract void Setup(AbilityDelivery data);
        public abstract void Execute(object aimingResult);
        public virtual void ExecuteTick(float timespan, object aimingResult)
        {
            Execute(aimingResult);
        }
        public abstract void Release();
        public abstract void Cancel();

        protected void EmitCostRequired() => CostRequired?.Invoke();
        protected void EmitContinuousCostRequired(float delta) => ContinuousCostRequired?.Invoke(delta);
    }
}
