namespace RtD.Data {
    public sealed class GameData {
        public List<EnemyClassData>? EnemyClasses { get; internal set; }
        public List<ItemQualityData>? ItemQualities { get; internal set; }
        public List<ItemData>? Items { get; internal set; }
        public List<LootData>? Loots { get; internal set; }
        public List<PlayerClassData>? PlayerClass { get; internal set; }
        public LevelUpData? LevelUp { get; internal set; }

        internal void Clear() {
            EnemyClasses = null;
            ItemQualities = null;
            Items = null;
            Loots = null;
            PlayerClass = null;
            LevelUp = null;
        }
    }
}