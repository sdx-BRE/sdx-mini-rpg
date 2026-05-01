using Godot;
using SDX.AbilitySystem.Resources.Windup;
using SDX.AbilitySystem.Core.Execution.Setup;
using SDX.AbilitySystem.Core.Execution.Recover;
using SDX.AbilitySystem.Core.Execution;

namespace SDX.AbilitySystem.Tests.Resources.Windup
{
    [Tool]
    public partial class AbilityWindupAnimationChannelingTests : EditorTestSuite
    {
        protected override void RunTests()
        {
            TestHandlerCreation();
        }

        private void TestHandlerCreation()
        {
            var windup = new AbilityWindupAnimationChanneling();
            var blackboard = new AbilityExecutionBlackboard();
            
            var setupHandler = windup.CreateHandler(null, blackboard);
            AssertTrue(setupHandler is DummySetupHandler, "Should create a DummySetupHandler");
            
            var recoverHandler = windup.CreateRecoverHandler(null, blackboard);
            AssertTrue(recoverHandler is DummyRecoverHandler, "Should create a DummyRecoverHandler");
        }
    }
}
