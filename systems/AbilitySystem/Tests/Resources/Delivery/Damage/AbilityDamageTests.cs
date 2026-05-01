using Godot;
using Godot.Collections;
using SDX.AbilitySystem.Resources.Delivery.Damage;
using SDX.AbilitySystem.Resources.Delivery.Damage.Modifiers;
using SDX.Damage;
using SDX.AbilitySystem.Tests;

namespace SDX.AbilitySystem.Tests.Resources.Delivery.Damage
{
    [Tool]
    public partial class AbilityDamageTests : EditorTestSuite
    {
        protected override void RunTests()
        {
            TestDamageInstanceCreation();
        }

        private void TestDamageInstanceCreation()
        {
            var abilityDamage = new AbilityDamage();
            abilityDamage.Modifiers.Add(new AbilityDamageModifierFlat { Damage = 10.0f });
            abilityDamage.PlayHitAnimation = false;
            
            var instance = DamageInstance.FromAbility(abilityDamage);
            
            AssertNotNull(instance, "DamageInstance should be created");
            AssertEqual(1, instance.GetPayloads().Count, "Should have 1 payload");
            AssertFalse(instance.ShouldTriggerHitAnimation(), "Should match play_hit_animation flag");
        }

        private void AssertNotNull(object obj, string message)
        {
            AssertTrue(obj != null, message);
        }
    }
}
