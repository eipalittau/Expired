namespace RtD.Data {
    public sealed class ItemQualityData : DataBase {
        internal ItemQualityData(Json.ItemQualityJsonData aJsonData, uint aSortOrder)
            : base(aJsonData.ID, aJsonData.Name, aJsonData.Description, aSortOrder) {
            CanBeDestroyed = aJsonData.CanBeDestroyed;
            IsDefault = aJsonData.IsDefault;

            Effect = new() {
                { EffectEnum.Primary, aJsonData.Effect == null ? 0 : aJsonData.Effect.Primary },
                { EffectEnum.Secondary, aJsonData.Effect == null ? 0 : aJsonData.Effect.Secondary }
            };
        }

        public ItemQualityData? Downgrade { get; internal set; }
        public ItemQualityData? Upgrade { get; internal set; }
        public bool CanBeDestroyed { get; set; }
        public bool IsDefault { get; set; }
        public Dictionary<EffectEnum, int> Effect { get; private set; }
    }
}