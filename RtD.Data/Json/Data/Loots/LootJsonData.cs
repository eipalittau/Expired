namespace RtD.Data.Json.Loot { // Json/Data/Loots
    internal sealed class LootJsonData : JsonDataBase {
        public int DiceResult { get; set; }
        public List<LootItemJsonData> Items { get; } = new List<LootItemJsonData>();
    }
}