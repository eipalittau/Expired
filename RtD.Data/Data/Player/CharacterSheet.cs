namespace RtD.Data {
    //Patrik: Fertigkeiten-Klassen erstellen. SkillTrapData, SkillLootingData, SkillAcrobaticsData, SkillIntimidateData, SkillAoOCountData, SkillReflexData, SkillWillData, SkillAntiSafetyThrowData
    //Tarik: Json mit Level-Up-Daten erstellen.
    public sealed class CharacterSheet {
        #region Properties / Felder
        public string CharacterName {
            get {
                return PlayerClass.CharacterName;
            }
        }
        public string CharacterClass {
            get {
                return PlayerClass.Name;
            }
        }
        public string CharacterDescription {
            get {
                return PlayerClass.Description;
            }
        }
        // Kling
        // Boon
        #region Attributes
        public AttributeOffenseData AttributeOffense { get; } = new AttributeOffenseData();
        public AttributeDefenseData AttributeDefense { get; } = new AttributeDefenseData();
        public AttributeWizardryData AttributeWizardry { get; } = new AttributeWizardryData();
        public AttributeWonderData AttributeWonder { get; } = new AttributeWonderData();
        public AttributeAuraData AttributeAura { get; } = new AttributeAuraData();
        #endregion

        #region Skills
        public SkillRecollectionData SkillRecollection { get; } = new SkillRecollectionData();
        public SkillSmithingData SkillRecollection { get; } = new SkillSmithingData();
        public SkillPerceptionData SkillRecollection { get; } = new SkillPerceptionData();
        public SkillTrapData SkillRecollection { get; } = new SkillTrapData();
        public SkillLootingData SkillRecollection { get; } = new SkillLootingData();
        public SkillAcrobaticsData SkillRecollection { get; } = new SkillAcrobaticsData();
        public SkillIntimidateData SkillRecollection { get; } = new SkillIntimidateData();
        public SkillAoOCountData SkillRecollection { get; } = new SkillAoOCountData();
        public SkillReflexData SkillRecollection { get; } = new SkillReflexData();
        public SkillWillData SkillRecollection { get; } = new SkillWillData();
        public SkillAntiSafetyThrowData SkillRecollection { get; } = new SkillAntiSafetyThrowData();

        #endregion

        #region Equipment
        public ItemData? Armor { get; set; }
        public ItemData? Mainhand { get; set; }
        public ItemData? Offhand { get; set; }
        public ItemData? RingFingerLeft { get; set; }
        public ItemData? RingFingerRight { get; set; }
        public ItemData? WristLeft { get; set; }
        public ItemData? WristRight { get; set; }
        public ItemData? Neck { get; set; }
        public ItemData? Shoulders { get; set; }
        public ItemData? Head { get; set; }
        public ItemData? Feet { get; set; }
        #endregion

        public int ArmorClass { get; private set; }
        public int Attack { get; private set; }
        public int Damage { get; private set; }
        public int WizardryLevel { get; private set; }
        public int WonderLevel { get; private set; }
        public int CharacterLevel { get; private set; }
        public ResourceData Mana { get; } = new ResourceData();
        public ResourceData Health { get; } = new ResourceData();
        public int Reflex { get; private set; }
        public int Will { get; private set; }

        private PlayerClassData PlayerClass { get; set; }
        #endregion

        #region Konstruktor
        public CharacterSheet(PlayerClassData aPlayerClass) {
            PlayerClass = aPlayerClass;
        }
        #endregion

        #region Methoden
        public void LevelUp(List<ITalent> aTalentList, List<SkillEnum> aSkillList) {

        }
        #endregion
    }
}
