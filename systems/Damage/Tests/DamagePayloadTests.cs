using Godot;
using SDX.Damage.Payloads;
using SDX.Stats;
using SDX.AbilitySystem.Tests;

namespace SDX.Damage.Tests
{
    [Tool]
    public partial class DamagePayloadTests : EditorTestSuite
    {
        protected override void RunTests()
        {
            TestFlatPayload();
            TestCurrentHealthPercentPayload();
            TestMaxHealthPercentPayload();
            TestDotPayload();
        }

        private void TestFlatPayload()
        {
            var payload = new DamagePayloadFlat(10.0f);
            AssertEqual(10.0f, payload.GetImmediateDamage(null), "Flat damage should match input");
        }

        private void TestCurrentHealthPercentPayload()
        {
            var payload = new DamagePayloadCurrentHealthPercent(50.0f);
            var mockStats = new MockStats { CurrentHealth = 100.0f };
            
            AssertEqual(50.0f, payload.GetImmediateDamage(mockStats), "Current health percent should calculate correctly");
        }

        private void TestMaxHealthPercentPayload()
        {
            var payload = new DamagePayloadMaxHealthPercent(25.0f);
            var mockStats = new MockStats { MaxHealth = 200.0f };
            
            AssertEqual(50.0f, payload.GetImmediateDamage(mockStats), "Max health percent should calculate correctly");
        }

        private void TestDotPayload()
        {
            var payload = new DamagePayloadDot(5.0f, 10.0f, 1.0f);
            AssertEqual(0.0f, payload.GetImmediateDamage(null), "Dot should have 0 immediate damage");
            AssertEqual(5.0f, payload.GetDamage(), "Dot damage should match");
        }

        private class MockStats : IEntityStats
        {
            public float CurrentHealth { get; set; }
            public float MaxHealth { get; set; }
        }
    }
}
