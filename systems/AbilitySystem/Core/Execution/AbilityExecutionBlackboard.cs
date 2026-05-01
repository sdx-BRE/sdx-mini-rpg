using Godot;
using Godot.Collections;

namespace SDX.AbilitySystem.Core.Execution
{
    public partial class AbilityExecutionBlackboard
    {
        public object AimingResult { get; set; } // TODO: Change to IAbilityAimingResult once ported
        public Array<Node3D> HitTargets { get; } = new Array<Node3D>();
        public bool IsReleased { get; set; } = false;
        public bool IsCancelled { get; set; } = false;

        public void Cleanup()
        {
            AimingResult = null;
            HitTargets.Clear();
            IsReleased = false;
            IsCancelled = false;
        }
    }
}
