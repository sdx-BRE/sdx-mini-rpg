using Godot;
using SDX.AbilitySystem.Resources.Trigger;
using SDX.AbilitySystem.Core.Execution.Execute.Trigger;
using SDX.AbilitySystem.Core.Execution;

namespace SDX.AbilitySystem.Tests.Resources.Trigger
{
    [Tool]
    public partial class AbilityTriggerNormalTests : EditorTestSuite
    {
        protected override void RunTests()
        {
            TestHandlerCreation();
        }

        private void TestHandlerCreation()
        {
            var trigger = new AbilityTriggerNormal();
            var blackboard = new AbilityExecutionBlackboard();
            var handler = trigger.CreateHandler(null, blackboard);
            
            AssertTrue(handler is DummyTriggerHandler, "Should create a DummyTriggerHandler");
        }
    }
}
