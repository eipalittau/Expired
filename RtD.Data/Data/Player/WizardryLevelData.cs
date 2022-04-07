namespace RtD.Data {
    public sealed class WizardryLevelData {
        internal WizardryLevelData(Json.PlayerClass.WizardryLevelJsonData aJsonData) {
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