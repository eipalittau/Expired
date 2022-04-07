namespace RtD.Data {
    public sealed class PlayerClassData : DataBase {
        #region Properties / Felder
        public string CharacterName { get; private set; }
        public ArmorClassData? ArmorClass { get; set; }
        public SkillData? Skill { get; set; }
        public HealthData? Health { get; set; }
        public HealData? Heal { get; set; }
        public string Mechanism { get; set; }
        public WizardryLevelData? WizardryLevel { get; set; }
        public WonderLevelData? WonderLevel { get; set; }
        #endregion

        #region Konstruktor
        internal PlayerClassData(Json.PlayerClass.PlayerClassJsonData aJsonData, uint aSortOrder)
            : base(aJsonData.ID, aJsonData.Name, aJsonData.Description, aSortOrder) {
            CharacterName = aJsonData.CharacterName ?? string.Empty;
            Mechanism = aJsonData.Mechanism ?? string.Empty;

            if (aJsonData.ArmorClass != null) {
                ArmorClass = new ArmorClassData(aJsonData.ArmorClass);
            }

            if (aJsonData.Health != null) {
                Health = new HealthData(aJsonData.Health);
            }

            if (aJsonData.Skill != null) {
                Skill = new SkillData(aJsonData.Skill);
            }

            if (aJsonData.Heal != null) {
                Heal = new HealData(aJsonData.Heal);
            }

            if (aJsonData.WizardryLevel != null) {
                WizardryLevel = new WizardryLevelData(aJsonData.WizardryLevel);
            }

            if (aJsonData.WonderLevel != null) {
                WonderLevel = new WonderLevelData(aJsonData.WonderLevel);
            }
        }
        #endregion

        #region Methoden

        #endregion
    }
}