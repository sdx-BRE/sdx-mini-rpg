using Godot;
using SDX.Stats;
using SDX.AbilitySystem.Tests;

namespace SDX.Stats.Tests
{
    [Tool]
    public partial class StatsTests : EditorTestSuite
    {
        protected override void RunTests()
        {
            TestGDScriptWrapper();
        }

        private void TestGDScriptWrapper()
        {
            var mockGDScript = new MockGDScript();
            mockGDScript.current_health = 75.0f;
            mockGDScript.max_health = 150.0f;
            
            var wrapper = new GDScriptEntityStats(mockGDScript);
            
            AssertEqual(75.0f, wrapper.CurrentHealth, "Wrapper should read current_health from GDScript source");
            AssertEqual(150.0f, wrapper.MaxHealth, "Wrapper should read max_health from GDScript source");
        }

        private partial class MockGDScript : RefCounted
        {
            [Export] public float current_health { get; set; }
            [Export] public float max_health { get; set; }
        }
    }
}
