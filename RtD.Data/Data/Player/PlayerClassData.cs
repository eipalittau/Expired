namespace RtD.Data {
    public sealed class PlayerClassData : DataBase {
        #region Properties / Felder
        public string CharacterName { get; set; }
        public ArmorClassData ArmorClass { get; set; }
        public HealthData Health { get; set; }
        public SkillData Skill { get; set; }
        public string Mechanism { get; set; }
        public WizardryLevelData WizardryLevel { get; set; }
        #endregion

        #region Konstruktor
        internal PlayerClassData(int aID, string aName, string aDescription) : base(aID,aName,aDescription) {

        }
        #endregion

        #region Methoden

        #endregion
    }
}