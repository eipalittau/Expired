namespace RtD.Data {
    public sealed class LootItemData {
        internal LootItemData(EnemyClassData aEnemyClass, ItemData aItem) => (EnemyClass, Item) = (aEnemyClass, aItem);

        public EnemyClassData EnemyClass { get; set; }
        public ItemData Item { get; set; }
    }
}