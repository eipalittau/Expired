namespace RtD.Data {
    public sealed class WonderLevelData {
        internal WonderLevelData(Json.PlayerClass.WonderLevelJsonData aJsonData) {
            Modifier = aJsonData.Modifier;

            if (aJsonData.Affects == null) {
                Affects = AffectEnum.None;
            } else {
                Affects = AffectEnum.Convert(aJsonData.Affects);
            }
        }

        public int Modifier { get; set; }
        public AffectEnum Affects { get; set; }
    }
}