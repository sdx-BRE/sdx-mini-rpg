using Godot;
using SDX.AbilitySystem.Resources.Windup;
using SDX.AbilitySystem.Core.Context;

namespace SDX.AbilitySystem.Core.Execution.Setup
{
    public partial class DummySetupHandler : AbilitySetupHandler
    {
        public DummySetupHandler(IAbilitySetupContext context, AbilityExecutionBlackboard blackboard) 
            : base(context, blackboard) { }

        public override void Setup(AbilityWindup data) { }
        public override void Start() { }
        public override void Tick(float delta) { }
        public override void Trigger() { }
        public override void HitEvent(Node3D target) { }
        public override void Cancel() { }
    }
}
