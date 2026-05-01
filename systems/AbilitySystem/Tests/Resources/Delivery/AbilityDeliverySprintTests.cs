using Godot;
using SDX.AbilitySystem.Resources.Delivery;
using SDX.AbilitySystem.Core.Execution.Execute.Delivery;

namespace SDX.AbilitySystem.Tests.Resources.Delivery
{
    [Tool]
    public partial class AbilityDeliverySprintTests : EditorTestSuite
    {
        protected override void RunTests()
        {
            TestHandlerCreation();
        }

        private void TestHandlerCreation()
        {
            var delivery = new AbilityDeliverySprint();
            var handler = delivery.CreateHandler(null, null);
            
            AssertTrue(handler is DummyDeliveryHandler, "Should create a DummyDeliveryHandler");
        }
    }
}
