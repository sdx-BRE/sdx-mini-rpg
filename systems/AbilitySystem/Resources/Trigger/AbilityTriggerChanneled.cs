using Godot;
using SDX.AbilitySystem.Core.Handlers;

namespace SDX.AbilitySystem.Resources.Trigger
{
    [GlobalClass]
    public partial class AbilityTriggerChanneled : AbilityTrigger
    {
        [Export] public float TickRate { get; set; } = 0.05f;

        public override IAbilityExecuteTriggerHandler CreateHandler(object blackboard)
        {
            return new DummyTriggerHandler(blackboard);
        }
    }
}
