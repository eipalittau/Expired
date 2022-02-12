namespace RtD.Data {
    public sealed class LevelUpData {
        #region Properties / Felder
        public int AttributeCount { get; set; }
        public int SkillCount { get; set; }
        public int Health { get; set; }
        #endregion

        #region Konstruktor
        internal LevelUpData(Json.LevelUpJsonData aJsonData) {
            AttributeCount = aJsonData.Attribute == null ? 1 : aJsonData.Attribute.Modifier;
            SkillCount = aJsonData.Skill == null ? 1 : aJsonData.Skill.Modifier;
            Health = aJsonData.Health == null ? 4 : aJsonData.Health.Modifier;
        }
        #endregion
    }
}