namespace RtD.Data.Json {
    internal sealed class LootJsonData {
        public int DiceResult { get; set; }
        public List<LootItemJsonData> Items { get; } = new List<LootItemJsonData>();
    }
}