using Godot;
using SDX.AbilitySystem.Resources.Trigger;
using SDX.AbilitySystem.Core.Execution.Execute.Trigger;

namespace SDX.AbilitySystem.Tests.Resources.Trigger
{
    [Tool]
    public partial class AbilityTriggerChargedTests : EditorTestSuite
    {
        protected override void RunTests()
        {
            TestHandlerCreation();
        }

        private void TestHandlerCreation()
        {
            var trigger = new AbilityTriggerCharged();
            var handler = trigger.CreateHandler(null);
            
            AssertTrue(handler is DummyTriggerHandler, "Should create a DummyTriggerHandler");
        }
    }
}
