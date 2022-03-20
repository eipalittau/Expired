namespace RtD.Data {
    public sealed class PlayerClassData : DataBase {
        #region Properties / Felder
        public string CharacterName { get; private set; }
        public ArmorClassData? ArmorClass { get; set; }
        public HealthData Health { get; set; }
        public SkillData Skill { get; set; }
        public string Mechanism { get; set; }
        public WizardryLevelData WizardryLevel { get; set; }
        #endregion

        #region Konstruktor
        internal PlayerClassData(Json.PlayerClass.PlayerClassJsonData aJsonData, uint aSortOrder)
            : base(aJsonData.ID, aJsonData.Name, aJsonData.Description, aSortOrder) {
            CharacterName = aJsonData.CharacterName ?? string.Empty;

        }
        #endregion

        #region Methoden

        #endregion
    }
}