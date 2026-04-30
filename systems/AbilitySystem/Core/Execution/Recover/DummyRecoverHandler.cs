using System;
using SDX.AbilitySystem.Resources.Windup;

namespace SDX.AbilitySystem.Core.Execution.Recover
{
    public partial class DummyRecoverHandler : IAbilityRecoverHandler
    {
        private readonly object _context;

        public DummyRecoverHandler(object context)
        {
            _context = context;
        }

        public void Setup(AbilityWindup data) { }
        public void Recover() { }
        public void Cancel() { }
    }
}
