namespace RtD.Data {
    public sealed class HealData {
        internal HealData(Json.PlayerClass.HealJsonData aJsonData) {
            Modifier = aJsonData.Modifier;
            Mechanism = aJsonData.Mechanism ?? string.Empty;

            if (aJsonData.Affects == null) {
                Affects = AffectEnum.None;
            } else {
                Affects = AffectEnum.Convert(aJsonData.Affects);
            }
        }

        public int Modifier { get; set; }
        public AffectEnum Affects { get; set; }
        public string Mechanism { get; set; }
    }
}