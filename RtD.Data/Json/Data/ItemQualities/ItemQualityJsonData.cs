namespace RtD.Data.Json {
    internal sealed class ItemQualityJsonData : JsonDataBase {
        public int? Downgrade { get; set; }
        public int? Upgrade { get; set; }
        public bool CanBeDestroyed { get; set; }
        public bool IsDefault { get; set; }
        public EffectJsonData? Effect { get; set; }
    }
}