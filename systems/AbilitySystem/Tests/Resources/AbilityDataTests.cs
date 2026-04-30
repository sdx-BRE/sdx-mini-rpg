using Godot;
using SDX.AbilitySystem.Resources;

namespace SDX.AbilitySystem.Tests.Resources
{
    [Tool]
    public partial class AbilityDataTests : EditorTestSuite
    {
        protected override void RunTests()
        {
            TestDefaultResourcesExist();
            // TODO: Re-enable strategy assignment tests once concrete classes exist
            // TestStrategyAssignment();
        }

        private void TestDefaultResourcesExist()
        {
            var data = new AbilityData();
            
            AssertTrue(data.Cost != null, "Default Cost should be initialized");
            AssertTrue(data.Cooldown != null, "Default Cooldown should be initialized");
        }
    }
}
