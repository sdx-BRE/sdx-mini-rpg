using Godot;
using SDX.AbilitySystem.Resources.Windup;
using SDX.AbilitySystem.Core.Execution.Setup;
using SDX.AbilitySystem.Core.Execution.Recover;

namespace SDX.AbilitySystem.Tests.Resources.Windup
{
    [Tool]
    public partial class AbilityWindupCasterAnimationTests : EditorTestSuite
    {
        protected override void RunTests()
        {
            TestInitialization();
            TestHandlerCreation();
        }

        private void TestInitialization()
        {
            var windup = new AbilityWindupCasterAnimation();
            windup.AnimName = "cast_spell";
            windup.AnimTrigger = "spell_start";
            
            AssertEqual("cast_spell", windup.AnimName, "AnimName should match");
            AssertEqual("spell_start", windup.AnimTrigger, "AnimTrigger should match");
        }

        private void TestHandlerCreation()
        {
            var windup = new AbilityWindupCasterAnimation();
            var setupHandler = windup.CreateSetupHandler(null, null);
            var recoverHandler = windup.CreateRecoverHandler(null);
            
            AssertTrue(setupHandler is DummySetupHandler, "Should create a DummySetupHandler");
            AssertTrue(recoverHandler is DummyRecoverHandler, "Should create a DummyRecoverHandler");
        }
    }
}
