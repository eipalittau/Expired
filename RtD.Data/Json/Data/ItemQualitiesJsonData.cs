namespace RtD.Data.Json {
    internal sealed class ItemQualitiesJsonData : JsonDataBase {
        public int? Downgrade { get; set; }
        public int? Upgrade { get; set; }
        public bool CanBreak { get; set; }
        public bool IsDefault { get; set; }
        public EffectJsonData? Effect { get; set; }
    }
}