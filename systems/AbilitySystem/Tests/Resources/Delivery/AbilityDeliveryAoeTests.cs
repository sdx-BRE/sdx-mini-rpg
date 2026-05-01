using Godot;
using SDX.AbilitySystem.Resources.Delivery;
using SDX.AbilitySystem.Core.Execution.Execute.Delivery;
using SDX.AbilitySystem.Core.Execution;

namespace SDX.AbilitySystem.Tests.Resources.Delivery
{
    [Tool]
    public partial class AbilityDeliveryAoeTests : EditorTestSuite
    {
        protected override void RunTests()
        {
            TestInitialization();
            TestHandlerCreation();
        }

        private void TestInitialization()
        {
            var delivery = new AbilityDeliveryAoe();
            delivery.Delay = 1.0f;
            delivery.Radius = 5.0f;
            
            AssertEqual(1.0f, delivery.Delay, "Delay should match");
            AssertEqual(5.0f, delivery.Radius, "Radius should match");
        }

        private void TestHandlerCreation()
        {
            var delivery = new AbilityDeliveryAoe();
            var blackboard = new AbilityExecutionBlackboard();
            var handler = delivery.CreateHandler(null, blackboard);
            
            AssertTrue(handler is DummyDeliveryHandler, "Should create a DummyDeliveryHandler");
        }
    }
}
