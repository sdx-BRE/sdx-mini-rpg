using Godot;
using SDX.AbilitySystem.Core.Execution.Setup;
using SDX.AbilitySystem.Core.Execution.Recover;
using SDX.AbilitySystem.Core.Execution;
using SDX.AbilitySystem.Core.Context;

namespace SDX.AbilitySystem.Resources.Windup
{
    [GlobalClass]
    public partial class AbilityWindupCasterAnimation : AbilityWindup
    {
        [Export] public string AnimationName { get; set; }
        [Export] public float PlaybackSpeed { get; set; } = 1.0f;

        public override IAbilitySetupHandler CreateHandler(IAbilitySetupContext context, AbilityExecutionBlackboard blackboard)
        {
            return new DummySetupHandler(context, blackboard);
        }

        public override IAbilityRecoverHandler CreateRecoverHandler(IAbilityRecoverContext context, AbilityExecutionBlackboard blackboard)
        {
            return new DummyRecoverHandler(context, blackboard);
        }
    }
}
