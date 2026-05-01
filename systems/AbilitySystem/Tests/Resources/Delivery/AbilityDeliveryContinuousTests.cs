using Godot;
using SDX.AbilitySystem.Resources.Delivery;
using SDX.AbilitySystem.Core.Execution.Execute.Delivery;

namespace SDX.AbilitySystem.Tests.Resources.Delivery
{
    [Tool]
    public partial class AbilityDeliveryContinuousTests : EditorTestSuite
    {
        protected override void RunTests()
        {
            TestInitialization();
            TestHandlerCreation();
        }

        private void TestInitialization()
        {
            var delivery = new AbilityDeliveryContinuous();
            delivery.TickRate = 0.1f;
            
            AssertEqual(0.1f, delivery.TickRate, "TickRate should match");
        }

        private void TestHandlerCreation()
        {
            var delivery = new AbilityDeliveryContinuous();
            var handler = delivery.CreateHandler(null, null);
            
            AssertTrue(handler is DummyDeliveryHandler, "Should create a DummyDeliveryHandler");
        }
    }
}
