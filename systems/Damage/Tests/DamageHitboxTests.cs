using Godot;
using SDX.Damage;
using SDX.AbilitySystem.Tests;

namespace SDX.Damage.Tests
{
    [Tool]
    public partial class DamageHitboxTests : EditorTestSuite
    {
        protected override void RunTests()
        {
            TestDamageDelegation();
            TestTargetPointDelegation();
        }

        private void TestDamageDelegation()
        {
            var hitbox = new DamageHitbox();
            var mockParent = new MockEntity();
            mockParent.AddChild(hitbox);
            
            var hit = new DamageInstance();
            hitbox.TakeDamage(hit);
            
            AssertTrue(mockParent.TakeDamageCalled, "Should delegate take_damage to parent");
        }

        private void TestTargetPointDelegation()
        {
            var hitbox = new DamageHitbox();
            var mockParent = new MockEntity();
            mockParent.AddChild(hitbox);
            
            var target = hitbox.GetTargetPoint();
            AssertEqual(mockParent, target, "Should delegate get_target_point to parent");
        }

        private partial class MockEntity : Node3D
        {
            public bool TakeDamageCalled { get; private set; } = false;

            // These methods are called via parent.Call() in DamageHitbox
            public void take_damage(DamageInstance hit)
            {
                TakeDamageCalled = true;
            }

            public Node3D get_target_point()
            {
                return this;
            }
        }
    }
}
