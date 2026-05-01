using System;
using SDX.AbilitySystem.Resources.Delivery;
using SDX.AbilitySystem.Core.Context;

namespace SDX.AbilitySystem.Core.Execution.Execute.Delivery
{
    public abstract partial class AbilityExecuteDeliveryHandler : IAbilityExecuteDeliveryHandler
    {
        public event Action CostRequired;
        public event Action<float> ContinuousCostRequired;

        protected readonly IAbilityExecuteContext Context;
        protected readonly AbilityExecutionBlackboard Blackboard;

        protected AbilityExecuteDeliveryHandler(IAbilityExecuteContext context, AbilityExecutionBlackboard blackboard)
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
