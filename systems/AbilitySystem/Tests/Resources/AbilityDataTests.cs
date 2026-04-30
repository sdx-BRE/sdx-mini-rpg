using Godot;
using SDX.AbilitySystem.Resources;
using SDX.AbilitySystem.Resources.Targeting;
using SDX.AbilitySystem.Resources.Delivery;

namespace SDX.AbilitySystem.Tests.Resources
{
    [Tool]
    public partial class AbilityDataTests : EditorTestSuite
    {
        protected override void RunTests()
        {
            TestDefaultResourcesExist();
            TestStrategyAssignment();
        }

        private void TestDefaultResourcesExist()
        {
            var data = new AbilityData();
            
            AssertTrue(data.Cost != null, "Default Cost should be initialized");
            AssertTrue(data.Cooldown != null, "Default Cooldown should be initialized");
        }

        private void TestStrategyAssignment()
        {
            var data = new AbilityData();
            var targeting = new AbilityTargeting();
            var delivery = new AbilityDelivery();
            
            data.Targeting = targeting;
            data.Delivery = delivery;
            
            AssertEqual(targeting, data.Targeting, "Should store Targeting resource");
            AssertEqual(delivery, data.Delivery, "Should store Delivery resource");
        }
    }
}
