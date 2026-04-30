using Godot;
using SDX.AbilitySystem.Resources;

namespace SDX.AbilitySystem.Tests.Resources
{
    [Tool]
    public partial class AbilityCooldownTests : EditorTestSuite
    {
        protected override void RunTests()
        {
            TestInitialization();
        }

        private void TestInitialization()
        {
            var cooldown = new AbilityCooldown();
            cooldown.Duration = 1.5f;
            cooldown.Type = AbilityCooldown.CooldownType.External;
            
            AssertEqual(1.5f, cooldown.Duration, "Duration should match");
            AssertEqual(AbilityCooldown.CooldownType.External, cooldown.Type, "Type should match");
        }
    }
}
