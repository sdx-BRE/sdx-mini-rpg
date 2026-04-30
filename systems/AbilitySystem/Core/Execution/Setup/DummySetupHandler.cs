using System;
using Godot;
using SDX.AbilitySystem.Resources.Windup;

namespace SDX.AbilitySystem.Core.Execution.Setup
{
    public partial class DummySetupHandler : IAbilitySetupHandler
    {
        public event Action VisualReady;

        private readonly object _context;
        private readonly object _blackboard;

        public DummySetupHandler(object context, object blackboard)
        {
            _context = context;
            _blackboard = blackboard;
        }

        public void Setup(AbilityWindup data) { }
        public void Start() { }
        public void Tick(float delta) { }
        public void Trigger() { }
        public void HitEvent(Node3D target) { }
        public void Cancel() { }
    }
}
