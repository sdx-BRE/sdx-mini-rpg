using Godot;
using SDX.AbilitySystem.Resources.Delivery;
using SDX.AbilitySystem.Core.Execution.Execute.Delivery;
using SDX.AbilitySystem.Core.Execution;

namespace SDX.AbilitySystem.Tests.Resources.Delivery
{
    [Tool]
    public partial class AbilityDeliveryBuffTests : EditorTestSuite
    {
        protected override void RunTests()
        {
            TestInitialization();
            TestHandlerCreation();
        }

        private void TestInitialization()
        {
            var delivery = new AbilityDeliveryBuff();
            delivery.Duration = 10.0f;
            
            AssertEqual(10.0f, delivery.Duration, "Duration should match");
        }

        private void TestHandlerCreation()
        {
            var delivery = new AbilityDeliveryBuff();
            var blackboard = new AbilityExecutionBlackboard();
            var handler = delivery.CreateHandler(null, blackboard);
            
            AssertTrue(handler is DummyDeliveryHandler, "Should create a DummyDeliveryHandler");
        }
    }
}
