using Godot;
using SDX.AbilitySystem.Resources.Targeting;
using SDX.AbilitySystem.Core.Execution.Aiming;

namespace SDX.AbilitySystem.Tests.Resources.Targeting
{
    [Tool]
    public partial class AbilityTargetingLocationTests : EditorTestSuite
    {
        protected override void RunTests()
        {
            TestInitialization();
            TestHandlerCreation();
        }

        private void TestInitialization()
        {
            var targeting = new AbilityTargetingLocation();
            targeting.CastRange = 15.0f;
            targeting.InputTrigger = "skill_1";
            
            AssertEqual(15.0f, targeting.CastRange, "CastRange should match");
            AssertEqual("skill_1", targeting.InputTrigger, "InputTrigger should match");
        }

        private void TestHandlerCreation()
        {
            var targeting = new AbilityTargetingLocation();
            var handler = targeting.CreateHandler(null);
            
            AssertTrue(handler is DummyAimingHandler, "Should create a DummyAimingHandler");
        }
    }
}
