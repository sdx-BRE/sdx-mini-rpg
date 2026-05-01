using Godot;
using SDX.AbilitySystem.Resources.Targeting;

namespace SDX.AbilitySystem.Core.Execution.Aiming
{
    public partial class DummyAimingHandler : AbilityAimingHandler
    {
        public DummyAimingHandler(IAbilityAimingContext context) : base(context) { }

        public override void Setup(AbilityTargeting data) { }
        public override object HandleInput(InputEvent @event) => null;
        public override void Tick(float delta) { }
        public override void Cancel() { }
    }
}
