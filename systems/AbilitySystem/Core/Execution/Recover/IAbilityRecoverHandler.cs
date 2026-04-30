using System;
using SDX.AbilitySystem.Resources.Windup;

namespace SDX.AbilitySystem.Core.Execution.Recover
{
    public interface IAbilityRecoverHandler
    {
        void Setup(AbilityWindup data);
        void Recover();
        void Cancel();
    }
}
