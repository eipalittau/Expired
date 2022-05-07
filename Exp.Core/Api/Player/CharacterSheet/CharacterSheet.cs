namespace Exp.Api.Player {
    public sealed class CharacterSheet : Data.Player.ICharacterSheetData {
        #region Properties / Felder
        public Data.Player.IPlayerClassData PlayerClass { get; init; }
        public Sheet.FeatData Feat { get; init; }
        public IList<Sheet.SkillData> SkillList { get; } = new List<Sheet.SkillData>();
        public IList<Sheet.EquipmentData> EquipmentList { get; } = new List<Sheet.EquipmentData>();
        public IList<Data.Misc.IRecollectionData> RecollectionList { get; } = new List<Data.Misc.IRecollectionData>();
        public Sheet.HealthData Health { get; init; }
        #endregion

        #region Konstruktor
        private CharacterSheet(Data.Player.IPlayerClassData aPlayerClass) { 
            PlayerClass = aPlayerClass;
            Feat = new Sheet.FeatData();
            Skill.SkillGroup.Singleton.Enumerate().ToList().ForEach(x => SkillList.Add(new Sheet.SkillData(x)));
            Slot.Singleton.Enumerate().Where(x => x.Available).ToList().ForEach(x => EquipmentList.Add(new Sheet.EquipmentData(x)));
            Health = new Sheet.HealthData(aPlayerClass.CanOverheal);
            
        }
        #endregion

        #region Methoden
        public static CharacterSheet Create() {
            Data.General.IDiceTypeData lDice = General.DiceType.Singleton.Get(Player.PlayerClass.Singleton.Count());
            
            return Create(Player.PlayerClass.Singleton.Enumerate().ElementAt(lDice.Roll()));
        }

        public static CharacterSheet Create(Data.Player.IPlayerClassData aPlayerClass) {
            CharacterSheet lNew = new(aPlayerClass);

            return lNew;
        }
        #endregion
    }
}