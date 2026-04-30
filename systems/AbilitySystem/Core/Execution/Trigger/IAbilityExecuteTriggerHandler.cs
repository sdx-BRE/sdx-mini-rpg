using System;
using SDX.AbilitySystem.Resources.Trigger;

namespace SDX.AbilitySystem.Core.Execution.Trigger
{
    public interface IAbilityExecuteTriggerHandler
    {
        event Action Triggered;
        event Action<float> TriggeredTick;
        event Action Finished;

        void Setup(AbilityTrigger data);
        void Start();
        void Tick(float delta);
        void Release();
        void Cancel();
    }
}
