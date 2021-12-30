namespace RtD.Data {
    public sealed class LootData {
        internal LootData(Json.LootJsonData aJsonData) {
            DiceResult = aJsonData.DiceResult;
        }    

        public int DiceResult { get; set; }
        public List<LootItemData> LootItem { get; } = new List<LootItemData>();
    }
}