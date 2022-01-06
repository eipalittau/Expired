namespace RtD.Data {
    public sealed class LootData {
        public int DiceResult { get; set; }
        public List<LootItemData> LootItem { get; } = new List<LootItemData>();
    }
}