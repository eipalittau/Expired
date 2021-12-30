namespace RtD.Data {
    public sealed class ItemQualityData : DataBase {
        internal ItemQualityData(Json.ItemQualitiesJsonData aJsonData, uint aSortOrder)
            : base(aJsonData.ID, aJsonData.Name, aJsonData.Description, aSortOrder) {
            CanBreak = aJsonData.CanBreak;
            IsDefault = aJsonData.IsDefault;

            Effect = new() {
                { EffectEnum.Primary, aJsonData.Effect == null ? 0 : aJsonData.Effect.Primary },
                { EffectEnum.Secondary, aJsonData.Effect == null ? 0 : aJsonData.Effect.Secondary }
            };
        }

        public ItemQualityData? Downgrade { get; internal set; }
        public ItemQualityData? Upgrade { get; internal set; }
        public bool CanBreak { get; set; }
        public bool IsDefault { get; set; }
        public Dictionary<EffectEnum, int> Effect { get; private set; }
    }
}