using Godot;
using SDX.AbilitySystem.Core.Execution.Setup;
using SDX.AbilitySystem.Core.Execution.Recover;

namespace SDX.AbilitySystem.Resources.Windup
{
    [GlobalClass]
    public partial class AbilityWindupMelee : AbilityWindup
    {
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
