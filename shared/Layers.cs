namespace SDX.Shared
{
    public static class Layers
    {
        // Visual Layers
        public const uint VISUAL_WORLD = 1 << 0;
        public const uint VISUAL_ENTITY = 1 << 1;
        public const uint VISUAL_EFFECT = 1 << 2;

        // Collision Layers
        public const uint COLLISION_PLAYER_COLLISION = 1 << 0;
        public const uint COLLISION_PLAYER_DAMAGE = 1 << 1;
        public const uint COLLISION_ENEMY_COLLISION = 1 << 2;
        public const uint COLLISION_ENEMY_DAMAGE = 1 << 3;
        public const uint COLLISION_WORLD = 1 << 4;
        public const uint COLLISION_PLAYER_SPELL = 1 << 5;
        public const uint COLLISION_ENEMY_SPELL = 1 << 6;
    }
}
