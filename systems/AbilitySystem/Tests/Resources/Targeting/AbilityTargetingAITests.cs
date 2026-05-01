using Godot;
using SDX.AbilitySystem.Resources.Targeting;
using SDX.AbilitySystem.Core.Execution.Aiming;

namespace SDX.AbilitySystem.Tests.Resources.Targeting
{
    [Tool]
    public partial class AbilityTargetingAITests : EditorTestSuite
    {
        protected override void RunTests()
        {
            TestHandlerCreation();
        }

        private void TestHandlerCreation()
        {
            var targeting = new AbilityTargetingAI();
            var handler = targeting.CreateHandler(null);
            
            AssertTrue(handler is DummyAimingHandler, "Should create a DummyAimingHandler");
        }
    }
}
