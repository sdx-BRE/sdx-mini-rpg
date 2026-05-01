using Godot;
using SDX.AbilitySystem.Resources.Delivery;
using SDX.AbilitySystem.Core.Execution.Execute.Delivery;

namespace SDX.AbilitySystem.Tests.Resources.Delivery
{
    [Tool]
    public partial class AbilityDeliveryProjectileTests : EditorTestSuite
    {
        protected override void RunTests()
        {
            TestInitialization();
            TestHandlerCreation();
        }

        private void TestInitialization()
        {
            var delivery = new AbilityDeliveryProjectile();
            delivery.Speed = 20.0f;
            delivery.Homing = AbilityDeliveryProjectile.HomingType.Simple;
            
            AssertEqual(20.0f, delivery.Speed, "Speed should match");
            AssertEqual(AbilityDeliveryProjectile.HomingType.Simple, delivery.Homing, "Homing should match");
        }

        private void TestHandlerCreation()
        {
            var delivery = new AbilityDeliveryProjectile();
            var handler = delivery.CreateHandler(null, null);
            
            AssertTrue(handler is DummyDeliveryHandler, "Should create a DummyDeliveryHandler");
        }
    }
}
