using Godot;
using SDX.AbilitySystem.Resources.Targeting;
using SDX.AbilitySystem.Core.Execution.Aiming;

namespace SDX.AbilitySystem.Tests.Resources.Targeting
{
    [Tool]
    public partial class AbilityTargetingAIDirectionalTests : EditorTestSuite
    {
        protected override void RunTests()
        {
            TestInitialization();
            TestHandlerCreation();
        }

        private void TestInitialization()
        {
            var targeting = new AbilityTargetingAIDirectional();
            
            AssertEqual(2.0f, targeting.AimSpeed, "AimSpeed default should be 2.0");
            AssertEqual(0.8f, targeting.LockOnDotThreshold, "LockOnDotThreshold default should be 0.8");
        }

        private void TestHandlerCreation()
        {
            var targeting = new AbilityTargetingAIDirectional();
            var handler = targeting.CreateHandler(null);
            
            AssertTrue(handler is DummyAimingHandler, "Should create a DummyAimingHandler");
        }
    }
}
