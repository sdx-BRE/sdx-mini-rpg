using Godot;
using Godot.Collections;
using SDX.Damage;
using SDX.Damage.Payloads;
using SDX.AbilitySystem.Tests;

namespace SDX.Damage.Tests
{
    [Tool]
    public partial class DamageInstanceTests : EditorTestSuite
    {
        protected override void RunTests()
        {
            TestInitialization();
        }

        private void TestInitialization()
        {
            var payloads = new Array<DamagePayload> { new DamagePayloadFlat(10.0f) };
            var instance = new DamageInstance(payloads, false);
            
            AssertEqual(1, instance.GetPayloads().Count, "Should have 1 payload");
            AssertFalse(instance.ShouldTriggerHitAnimation(), "Should respect hit animation flag");
        }
    }
}
