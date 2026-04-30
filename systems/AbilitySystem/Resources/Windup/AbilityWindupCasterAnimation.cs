using Godot;
using SDX.AbilitySystem.Core.Execution.Setup;
using SDX.AbilitySystem.Core.Execution.Recover;

namespace SDX.AbilitySystem.Resources.Windup
{
    [GlobalClass]
    public partial class AbilityWindupCasterAnimation : AbilityWindup
    {
        [Export] public string AnimTrigger { get; set; } = "";
        [Export] public string AnimName { get; set; } = "";
        [Export] public string CallMethodTrackName { get; set; } = "execute_cast";

        public float CastPoint { get; set; } = 0.1f;

        public override IAbilitySetupHandler CreateSetupHandler(object context, object blackboard)
        {
            return new DummySetupHandler(context, blackboard);
        }

        public override IAbilityRecoverHandler CreateRecoverHandler(object context)
        {
            return new DummyRecoverHandler(context);
        }
    }
}
