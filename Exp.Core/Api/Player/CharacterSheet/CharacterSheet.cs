namespace Exp.Api.Player {
    public sealed class CharacterSheet : Data.Player.ICharacterSheetData {
        #region Properties / Felder
        public bool IsDead { get; internal set; } = true;
        public int Level { get; private set; } = 0;
        public Data.Player.IPlayerClassData PlayerClass { get; init; }
        public Sheet.ExperienceData Experience { get; init; }
        public Sheet.HealthData Health { get; init; }
        public Sheet.ArmorClassData ArmorClass { get; init; }
        public Sheet.ResistenceData Resistence { get; init; }
        public IList<Sheet.AttackData> Attack { 
            get { 
                return _Attack.AsReadOnly();
            } 
        }
        public IList<Sheet.DamageData> Damage {
            get {
                return _Damage.AsReadOnly();
            }
        }
        public Sheet.SneakyData Sneaky { get; init; }
        public Sheet.ConjureData Conjure { get; init; }
        public Sheet.MovementData Movement { get; init; }
        public Sheet.FeatData Feat { get; init; }
        public IList<Sheet.SkillData> SkillList { get; } = new List<Sheet.SkillData>();
        public IList<Sheet.EquipmentData> EquipmentList { get; } = new List<Sheet.EquipmentData>();
        public IList<Data.Misc.IRecollectionData> RecollectionList { get; } = new List<Data.Misc.IRecollectionData>();

        private readonly List<Sheet.AttackData> _Attack = new();
        private readonly List<Sheet.DamageData> _Damage = new();
        #endregion

        #region Konstruktor
        private CharacterSheet(Data.Player.IPlayerClassData aPlayerClass, int aExperience4LevelUp) { 
            PlayerClass = aPlayerClass;
            Experience = new Sheet.ExperienceData(this) {
                Max = aExperience4LevelUp
            };
            Health = new Sheet.HealthData(this);
            ArmorClass = new Sheet.ArmorClassData(this);
            Resistence = new Sheet.ResistenceData(this);
            General.DamageType.Singleton.Enumerate().ToList().ForEach(x => { 
                _Attack.Add(new Sheet.AttackData(this, x)); 
                _Damage.Add(new Sheet.DamageData(this, x)); 
            });
            Sneaky = new Sheet.SneakyData(this);
            Conjure = new Sheet.ConjureData(this);
            Movement = new Sheet.MovementData(this);
            Feat = new Sheet.FeatData();
            Skill.SkillType.Singleton.Enumerate().ToList()
                .ForEach(x => SkillList.Add(new Sheet.SkillData(x)));
            Slot.Singleton.Enumerate()
                .Where(x => x.Available).ToList()
                .ForEach(x => EquipmentList.Add(new Sheet.EquipmentData(x)));
        }
        #endregion

        #region Methoden
        #region Create
        public static CharacterSheet Create(int aExperience4LevelUp) {
            int lRandomResult = new Random().Next(1, Player.PlayerClass.Singleton.Count());
            
            return Create(Player.PlayerClass.Singleton.Enumerate().ElementAt(lRandomResult), aExperience4LevelUp);
        }

        public static CharacterSheet Create(Data.Player.IPlayerClassData aPlayerClass, int aExperience4LevelUp) {
            return new(aPlayerClass, aExperience4LevelUp);
        }
        #endregion

        #region LevelUp
        public bool LevelUp(Data.Feat.IFeatDataBase[] aFeatTalents, Data.Skill.ISkillTypeData[] aSkills) {
            if (Experience.Current < Experience.Max) {
                return false;
            } else {
                int lAttackMax = LevelUpMax(General.CharacterChangerEnum.Attack);
                int lDamagekMax = LevelUpMax(General.CharacterChangerEnum.Damage);

                Experience.LevelUp();
                Level++;

                Health.Max = LevelUpMax(General.CharacterChangerEnum.Health);
                ArmorClass.Max = LevelUpMax(General.CharacterChangerEnum.Armor);
                Resistence.Max = LevelUpMax(General.CharacterChangerEnum.Resistence);
                Attack.ToList().ForEach(x => x.Max = lAttackMax);
                Damage.ToList().ForEach(x => x.Max = lDamagekMax);
                Sneaky.Max = LevelUpMax(General.CharacterChangerEnum.Sneaky);
                Conjure.Mana.Max = LevelUpMax(General.CharacterChangerEnum.Mana);
                Movement.Max = LevelUpMax(General.CharacterChangerEnum.Movement);
                if (Player.LevelUp.Singleton.Contains(General.CharacterChangerEnum.FeatPoints) && aFeatTalents != null) {
                    int lFeatPoints = Player.LevelUp.Singleton.Get(General.CharacterChangerEnum.FeatPoints).Base.Value;

                    for (int lI = 0; lI < Math.Min(aFeatTalents.Length, lFeatPoints); lI++) {
                        Feat.LevelUp(aFeatTalents[lI]);
                    }
                }
                if (Player.LevelUp.Singleton.Contains(General.CharacterChangerEnum.SkillPoints) && aSkills != null) {
                    int lSkillPoints = Player.LevelUp.Singleton.Get(General.CharacterChangerEnum.SkillPoints).Base.Value;

                    for (int lI = 0; lI < Math.Min(aSkills.Length, lSkillPoints); lI++) {
                        IEnumerable<Sheet.SkillTypeData> lSkill = SkillList
                            .SelectMany(x => x.SkillTypeList)
                            .Where(x => x.SkillType.Equals(aSkills[lI]));

                        if (lSkill.Any() && lSkill.Count() == 1) {
                            lSkill.First().LevelUp();
                        }
                    }
                }

                OnNewDay();

                return true;
            }
        }

        private int LevelUpMax(General.CharacterChangerEnum aChanger) {
            int lResult = 0;

            // Änderung durch Level-Up
            if (Player.LevelUp.Singleton.Contains(aChanger)) {
                Data.Player.ILevelUpData lLevelUpData = Player.LevelUp.Singleton.Get(aChanger);

                lResult = lLevelUpData.Base.Value * Level;
            }

            // Änderung durch Charakterklasse
            Data.Misc.IAptitudeData? lAptitude = PlayerClass.AptitudeList.Where(x => aChanger.Equals(x.Changer)).FirstOrDefault();

            if (lAptitude != null) {
                if (lAptitude.Base.HasData) {
                    lResult = lAptitude.Base.Value * Level;
                }

                lResult += IncreaseModifierData(lAptitude.Modifier, 0);
                lResult *= IncreaseModifierData(lAptitude.Multiplicator, 1);
                lResult /= IncreaseModifierData(lAptitude.Divisor, 1);
            }

            return lResult;
        }

        private int IncreaseModifierData(Data.Misc.ModifierData aModifier, int aDefault) {
            if (aModifier.HasData) {
                return aModifier.Value * ((int)Math.Floor((double)Level / aModifier.Intervall) + 1);
            } else {
                return aDefault;
            }
        }
        #endregion

        public void OnNewDay() {
            IsDead = false;

            Health.OnNewDay();
            ArmorClass.OnNewDay();
            Resistence.OnNewDay();
            Attack.ToList().ForEach(x => x.OnNewDay());
            Damage.ToList().ForEach(x => x.OnNewDay());
            Sneaky.OnNewDay();
            Conjure.OnNewDay();
            Movement.OnNewDay();
        }
        #endregion
    }
}