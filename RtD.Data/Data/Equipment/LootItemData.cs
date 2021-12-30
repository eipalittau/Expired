namespace RtD.Data {
    public sealed class LootItemData {
        internal LootItemData(Json.LootItemJsonData aJsonData) {
            
        }

        public EnemyClassData EnemyClass { get; set; }
        public ItemData Item { get; set; }
    }
}