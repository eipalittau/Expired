namespace RtD.Data {
    public sealed class CharacterSheet {
        #region Properties / Felder
        public CharacterData Character { get; }
        // Kling
        // Boon
        public AttributesData Attributes { get; } = new AttributesData();
        public SkillsData Skills { get; } = new SkillsData();
        public EquipmentData Equipment { get; } = new EquipmentData();
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
        #endregion

        #region Konstruktor
        internal CharacterSheet(PlayerClassData aPlayerClass) {
            Character = new CharacterData(aPlayerClass);
        }
        #endregion

        #region Methoden
        internal void LevelUp(List<ITalent> aTalentList, List<SkillEnum> aSkillList) {

        }
        #endregion

        #region Verschachtelte Klassen
        public class CharacterData {
            #region Properties / Felder
            public string Name {
                get {
                    return PlayerClass.CharacterName;
                }
            }
            public string Class {
                get {
                    return PlayerClass.Name;
                }
            }
            public string Description {
                get {
                    return PlayerClass.Description;
                }
            }
            internal PlayerClassData PlayerClass { get; }
            #endregion

            #region Konstruktor
            internal CharacterData(PlayerClassData aPlayerClass) {
                PlayerClass = aPlayerClass;
            }
            #endregion
        }

        public class AttributesData {
            public AttributeOffenseData Offense { get; } = new AttributeOffenseData();
            public AttributeDefenseData Defense { get; } = new AttributeDefenseData();
            public AttributeWizardryData Wizardry { get; } = new AttributeWizardryData();
            public AttributeWonderData Wonder { get; } = new AttributeWonderData();
            public AttributeAuraData Aura { get; } = new AttributeAuraData();
        }

        public class SkillsData {
            public SkillRecollectionData SkillRecollection { get; } = new SkillRecollectionData();
            public SkillSmithingData SkillSmithing { get; } = new SkillSmithingData();
            public SkillPerceptionData SkillPerception { get; } = new SkillPerceptionData();
            public SkillTrapData SkillTrap { get; } = new SkillTrapData();
            public SkillLootingData SkillLooting { get; } = new SkillLootingData();
            public SkillAcrobaticsData SkillAcrobatics { get; } = new SkillAcrobaticsData();
            public SkillIntimidateData SkillIntimidate { get; } = new SkillIntimidateData();
            public SkillAoOCountData SkillAoOCount { get; } = new SkillAoOCountData();
            public SkillReflexData SkillReflex { get; } = new SkillReflexData();
            public SkillWillData SkillWill { get; } = new SkillWillData();
            public SkillAntiSafetyThrowData SkillAntiSafetyThrow { get; } = new SkillAntiSafetyThrowData();
        }

        public class EquipmentData {
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
        }
        #endregion
    }
}