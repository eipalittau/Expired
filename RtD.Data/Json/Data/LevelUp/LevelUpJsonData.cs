namespace RtD.Data.Json {
    internal class LevelUpJsonData : JsonDataBase {
        #region Properties / Felder
        public AttributeJsonData? Attribute { get; set; }
        public SkillJsonData? Skill { get; set; }
        public HealthJsonData? Health { get; set; }
        #endregion
    }
}