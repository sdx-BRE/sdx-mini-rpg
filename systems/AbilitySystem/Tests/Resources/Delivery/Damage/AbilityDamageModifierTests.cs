using Godot;
using SDX.AbilitySystem.Resources.Delivery.Damage.Modifiers;
using SDX.Damage.Payloads;
using SDX.AbilitySystem.Tests;

namespace SDX.AbilitySystem.Tests.Resources.Delivery.Damage
{
    [Tool]
    public partial class AbilityDamageModifierTests : EditorTestSuite
    {
        protected override void RunTests()
        {
            TestFlatModifier();
            TestCurrentHealthPercentModifier();
            TestMaxHealthPercentModifier();
            TestDotModifier();
        }

        private void TestFlatModifier()
        {
            var modifier = new AbilityDamageModifierFlat { Damage = 15.0f };
            var payload = modifier.ToPayload() as DamagePayloadFlat;
            
            AssertNotNull(payload, "Payload should be DamagePayloadFlat");
            AssertEqual(15.0f, payload.GetImmediateDamage(null), "Damage value should be preserved");
        }

        private void TestCurrentHealthPercentModifier()
        {
            var modifier = new AbilityDamageModifierCurrentHealthPercent { Percent = 12.0f };
            var payload = modifier.ToPayload() as DamagePayloadCurrentHealthPercent;
            
            AssertNotNull(payload, "Payload should be DamagePayloadCurrentHealthPercent");
        }

        private void TestMaxHealthPercentModifier()
        {
            var modifier = new AbilityDamageModifierMaxHealthPercent { Percent = 8.0f };
            var payload = modifier.ToPayload() as DamagePayloadMaxHealthPercent;
            
            AssertNotNull(payload, "Payload should be DamagePayloadMaxHealthPercent");
        }

        private void TestDotModifier()
        {
            var modifier = new AbilityDamageModifierDot 
            { 
                Damage = 5.0f, 
                Duration = 3.0f, 
                Interval = 0.5f 
            };
            var payload = modifier.ToPayload() as DamagePayloadDot;
            
            AssertNotNull(payload, "Payload should be DamagePayloadDot");
            AssertEqual(5.0f, payload.GetDamage(), "Damage should match");
        }

        // Added simple helper since EditorTestSuite doesn't have AssertNotNull (based on previous view)
        private void AssertNotNull(object obj, string message)
        {
            AssertTrue(obj != null, message);
        }
    }
}
