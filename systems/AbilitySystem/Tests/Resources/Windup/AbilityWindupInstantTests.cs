using Godot;
using SDX.AbilitySystem.Resources.Windup;
using SDX.AbilitySystem.Core.Execution.Setup;
using SDX.AbilitySystem.Core.Execution.Recover;

namespace SDX.AbilitySystem.Tests.Resources.Windup
{
    [Tool]
    public partial class AbilityWindupInstantTests : EditorTestSuite
    {
        protected override void RunTests()
        {
            TestHandlerCreation();
        }

        private void TestHandlerCreation()
        {
            var windup = new AbilityWindupInstant();
            var setupHandler = windup.CreateSetupHandler(null, null);
            var recoverHandler = windup.CreateRecoverHandler(null);
            
            AssertTrue(setupHandler is DummySetupHandler, "Should create a DummySetupHandler");
            AssertTrue(recoverHandler is DummyRecoverHandler, "Should create a DummyRecoverHandler");
        }
    }
}
