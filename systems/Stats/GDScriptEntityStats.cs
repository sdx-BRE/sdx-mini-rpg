using Godot;

namespace SDX.Stats
{
    public partial class GDScriptEntityStats : IEntityStats
    {
        private readonly GodotObject _source;

        public GDScriptEntityStats(GodotObject source)
        {
            _source = source;
        }

        public float CurrentHealth => (float)_source.Get("current_health");
        public float MaxHealth => (float)_source.Get("max_health");
    }
}
