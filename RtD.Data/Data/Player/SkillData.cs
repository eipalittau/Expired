namespace RtD.Data {
    public sealed class SkillData {
        internal SkillData(Json.PlayerClass.SkillJsonData aJsonData) {
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