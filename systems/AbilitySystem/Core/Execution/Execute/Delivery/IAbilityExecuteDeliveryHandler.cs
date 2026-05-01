using System;
using SDX.AbilitySystem.Resources.Delivery;

namespace SDX.AbilitySystem.Core.Execution.Execute.Delivery
{
    public interface IAbilityExecuteDeliveryHandler
    {
        event Action CostRequired;
        event Action<float> ContinuousCostRequired;

        void Setup(AbilityDelivery data);
        void Execute(object aimingResult);
        void ExecuteTick(float timespan, object aimingResult);
        void Release();
        void Cancel();
    }
}
