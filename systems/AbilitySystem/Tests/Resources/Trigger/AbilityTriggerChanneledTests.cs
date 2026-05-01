using Godot;
using SDX.AbilitySystem.Resources.Trigger;
using SDX.AbilitySystem.Core.Execution.Execute.Trigger;

namespace SDX.AbilitySystem.Tests.Resources.Trigger
{
    [Tool]
    public partial class AbilityTriggerChanneledTests : EditorTestSuite
    {
        protected override void RunTests()
        {
            TestInitialization();
            TestHandlerCreation();
        }

        private void TestInitialization()
        {
            var trigger = new AbilityTriggerChanneled();
            trigger.TickRate = 0.1f;
            
            AssertEqual(0.1f, trigger.TickRate, "TickRate should match assigned value");
        }

        private void TestHandlerCreation()
        {
            var trigger = new AbilityTriggerChanneled();
            var handler = trigger.CreateHandler(null);
            
            AssertTrue(handler is DummyTriggerHandler, "Should create a DummyTriggerHandler");
        }
    }
}
