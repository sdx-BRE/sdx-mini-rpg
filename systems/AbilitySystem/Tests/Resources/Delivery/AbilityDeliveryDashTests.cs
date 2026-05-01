using Godot;
using SDX.AbilitySystem.Resources.Delivery;
using SDX.AbilitySystem.Core.Execution.Execute.Delivery;
using SDX.AbilitySystem.Core.Execution;

namespace SDX.AbilitySystem.Tests.Resources.Delivery
{
    [Tool]
    public partial class AbilityDeliveryDashTests : EditorTestSuite
    {
        protected override void RunTests()
        {
            TestInitialization();
            TestHandlerCreation();
        }

        private void TestInitialization()
        {
            var delivery = new AbilityDeliveryDash();
            delivery.DashPower = 20.0f;
            
            AssertEqual(20.0f, delivery.DashPower, "DashPower should match");
        }

        private void TestHandlerCreation()
        {
            var delivery = new AbilityDeliveryDash();
            var blackboard = new AbilityExecutionBlackboard();
            var handler = delivery.CreateHandler(null, blackboard);
            
            AssertTrue(handler is DummyDeliveryHandler, "Should create a DummyDeliveryHandler");
        }
    }
}
