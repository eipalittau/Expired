namespace Exp.Api.Player {
    public sealed class CharacterSheet : Data.Player.ICharacterSheetData {
        #region Properties / Felder
        public bool IsDead { get; internal set; } = true;
        public int Level { get; private set; } = 1;
        public Data.Player.IPlayerClassData PlayerClass { get; init; }
        public Sheet.HealthData Health { get; init; }
        public Sheet.ConjureData Conjure { get; init; }
        public Sheet.FeatData Feat { get; } = new Sheet.FeatData();
        public IList<Sheet.SkillData> SkillList { get; } = new List<Sheet.SkillData>();
        public IList<Sheet.EquipmentData> EquipmentList { get; } = new List<Sheet.EquipmentData>();
        public IList<Data.Misc.IRecollectionData> RecollectionList { get; } = new List<Data.Misc.IRecollectionData>();
        #endregion

        #region Konstruktor
        private CharacterSheet(Data.Player.IPlayerClassData aPlayerClass) { 
            PlayerClass = aPlayerClass;
            Health = new Sheet.HealthData(this);
            Conjure = new Sheet.ConjureData(this);
            
            LevelUp();

            //Skill.SkillGroup.Singleton.Enumerate().ToList().ForEach(x => SkillList.Add(new Sheet.SkillData(x)));
            //Slot.Singleton.Enumerate().Where(x => x.Available).ToList().ForEach(x => EquipmentList.Add(new Sheet.EquipmentData(x)));

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

        public void OnNewDay() {
            IsDead = false;

            Health.OnNewDay();
            Conjure.OnNewDay();
        }

        #region LevelUp
        public void LevelUp() {
            Level++;

            Health.Max = LevelUpMax(General.CharacterChangerEnum.Health);
            Health.OnNewDay();

            Conjure.Mana.Max = LevelUpMax(General.CharacterChangerEnum.Mana);
            Conjure.Mana.OnNewDay();

            LevelUpFeat();
        }

        private int LevelUpMax(General.CharacterChangerEnum aChanger) {
            int lResult = 0;

            if (Player.LevelUp.Singleton.Contains(aChanger)) {
                Data.Player.ILevelUpData lLevelUpData = Player.LevelUp.Singleton.Get(aChanger);

                lResult = lLevelUpData.Base.Value * Level;
            }

            Data.Misc.IAptitudeData? lAptitudeHealth = PlayerClass.AptitudeList.Where(x => aChanger.Equals(x.Changer)).FirstOrDefault();

            if (lAptitudeHealth != null) {
                if (lAptitudeHealth.Base.HasData) {
                    lResult = lAptitudeHealth.Base.Value * Level;
                }

                lResult += IncreaseModifierData(lAptitudeHealth.Modifier);
                lResult *= IncreaseModifierData(lAptitudeHealth.Multiplicator);
                lResult /= IncreaseModifierData(lAptitudeHealth.Divisor);
            }

            return lResult;
        }

        private void LevelUpFeat() {
            if (Player.LevelUp.Singleton.Contains(General.CharacterChangerEnum.FeatPoints)) {
                Data.Player.ILevelUpData lLevelUpData = Player.LevelUp.Singleton.Get(General.CharacterChangerEnum.FeatPoints);

            }
        }

        private int IncreaseModifierData(Data.Misc.ModifierData aModifier) {
            if (aModifier.HasData) {
                return aModifier.Value * ((int)Math.Floor((double)Level / aModifier.Intervall) + 1);
            } else {
                return 0;
            }
        }
        #endregion
        #endregion
    }
}