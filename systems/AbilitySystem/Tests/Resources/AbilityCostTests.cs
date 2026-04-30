using Godot;
using SDX.AbilitySystem.Resources;

namespace SDX.AbilitySystem.Tests.Resources
{
    [Tool]
    public partial class AbilityCostTests : EditorTestSuite
    {
        protected override void RunTests()
        {
            TestInitialization();
        }

        private void TestInitialization()
        {
            var cost = new AbilityCost();
            cost.Mana = 25.0f;
            cost.Stamina = 10.0f;
            cost.Type = AbilityCost.CostType.Instant;
            
            AssertEqual(25.0f, cost.Mana, "Mana should match");
            AssertEqual(10.0f, cost.Stamina, "Stamina should match");
            AssertEqual(AbilityCost.CostType.Instant, cost.Type, "Type should match");
        }
    }
}
