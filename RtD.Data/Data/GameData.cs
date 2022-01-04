namespace RtD.Data {
    public sealed class GameData {
        public List<EnemyClassData>? EnemyClasses { get; set; }
        public List<ItemQualityData>? ItemQualities { get; set; }
        public List<ItemData>? Items { get; set; }
        public List<LootData>? Loots { get; set; }
    }
}