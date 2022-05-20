using Exp.Api.General;
using Exp.Api.Helper;

namespace Exp.Core {
    public sealed class CharacterSheet : Data.Player.ICharacterSheetData {
        #region Properties / Felder
        public bool IsDead { get; internal set; } = true;
        public int Level { get; private set; } = 0;
        public Data.Player.PlayerClass.IPlayerClassData PlayerClass { get; init; }
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
        public Sheet.SmithingData Smithing { get; init; }
        public Sheet.SneakyData Sneaky { get; init; }
        public Sheet.ConjureData Conjure { get; init; }
        public Sheet.MovementData Movement { get; init; }
        public Sheet.FeatData Feat { get; init; }
        public IList<Sheet.SkillData> SkillList { get; } = new List<Sheet.SkillData>();
        public IList<Sheet.EquipmentData> EquipmentList { get; } = new List<Sheet.EquipmentData>();
        public IList<Data.Misc.Recollection.IRecollectionData> RecollectionList { get; } = new List<Data.Misc.Recollection.IRecollectionData>();

        private readonly List<Sheet.AttackData> _Attack = new();
        private readonly List<Sheet.DamageData> _Damage = new();
        #endregion

        #region Konstruktor
        private CharacterSheet(Data.Player.PlayerClass.IPlayerClassData aPlayerClass, int aExperience4LevelUp) { 
            PlayerClass = aPlayerClass;
            Experience = new Sheet.ExperienceData(this) {
                Max = aExperience4LevelUp
            };
            Health = new Sheet.HealthData(this);
            ArmorClass = new Sheet.ArmorClassData(this);
            Resistence = new Sheet.ResistenceData(this);
            DamageType.Singleton.Enumerate().ToList().ForEach(x => { 
                _Attack.Add(new Sheet.AttackData(this, x)); 
                _Damage.Add(new Sheet.DamageData(this, x)); 
            });
            Smithing = new Sheet.SmithingData();
            Sneaky = new Sheet.SneakyData(this);
            Conjure = new Sheet.ConjureData(this);
            Movement = new Sheet.MovementData(this);
            Feat = new Sheet.FeatData();
            Api.Skill.SkillType.Singleton.Enumerate().ToList()
                .ForEach(x => SkillList.Add(new Sheet.SkillData(x)));
            Api.Player.Slot.Singleton.Enumerate()
                .Where(x => x.Available).ToList()
                .ForEach(x => EquipmentList.Add(new Sheet.EquipmentData(x)));
        }
        #endregion

        #region Methoden
        #region Create
        public static CharacterSheet Create(int aExperience4LevelUp) {
            int lPlayerClasses = Api.Player.PlayerClass.Singleton.Count();

            if (lPlayerClasses == 0) {
                Util.ExceptionHandler.Add(new Exception.MissingInitializationException());
            }
            
            return Create(Api.Player.PlayerClass.Singleton.Enumerate().ElementAt(new Random().Next(1, lPlayerClasses)), aExperience4LevelUp);
        }

        public static CharacterSheet Create(Data.Player.PlayerClass.IPlayerClassData aPlayerClass, int aExperience4LevelUp) {
            return new(aPlayerClass, aExperience4LevelUp);
        }
        #endregion

        #region LevelUp
        public bool LevelUp(Data.Feat.IFeatDataBase[] aFeatTalents, Data.Skill.SkillType.ISkillTypeData[] aSkills) {
            if (Experience.Current < Experience.Max) {
                return false;
            } else {
                int lAttackMax = LevelUpMax(TargetEffectEnum.Attack);
                int lDamagekMax = LevelUpMax(TargetEffectEnum.Damage);

                Experience.LevelUp(); // Erfahrungspunkte zurücksetzen
                Level++;

                Health.Max = LevelUpMax(TargetEffectEnum.Health);
                ArmorClass.Max = LevelUpMax(TargetEffectEnum.Armor);
                if (Api.Player.LevelUp.Singleton.Contains(TargetEffectEnum.NaturalArmor)) {
                    ArmorClass.Natural = Api.Player.LevelUp.Singleton.Get(TargetEffectEnum.NaturalArmor).Base.Value;
                }
                Resistence.Max = LevelUpMax(TargetEffectEnum.Resistence);
                Attack.ToList().ForEach(x => x.Max = lAttackMax);
                Damage.ToList().ForEach(x => x.Max = lDamagekMax);
                Sneaky.Max = LevelUpMax(TargetEffectEnum.Sneaky);
                Conjure.Mana.Max = LevelUpMax(TargetEffectEnum.Mana);
                Movement.Max = LevelUpMax(TargetEffectEnum.Movement);
                if (Api.Player.LevelUp.Singleton.Contains(TargetEffectEnum.FeatPoints) && aFeatTalents != null) {
                    int lFeatPoints = Api.Player.LevelUp.Singleton.Get(TargetEffectEnum.FeatPoints).Base.Value;

                    for (int lI = 0; lI < Math.Min(aFeatTalents.Length, lFeatPoints); lI++) {
                        Feat.LevelUp(aFeatTalents[lI]);
                    }
                }
                if (Api.Player.LevelUp.Singleton.Contains(TargetEffectEnum.SkillPoints) && aSkills != null) {
                    int lSkillPoints = Api.Player.LevelUp.Singleton.Get(TargetEffectEnum.SkillPoints).Base.Value;

                    for (int lI = 0; lI < Math.Min(aSkills.Length, lSkillPoints); lI++) {
                        IEnumerable<Sheet.SkillData> lSkill = SkillList
                            .Where(x => x.SkillType.Equals(aSkills[lI]));

                        if (lSkill.Any()) {
                            lSkill.First().LevelUp();
                        }
                    }
                }

                OnNewDay();

                return true;
            }
        }

        private int LevelUpMax(TargetEffectEnum aEffect) {
            int lResult = 0;

            // Änderung durch Level-Up
            if (Api.Player.LevelUp.Singleton.Contains(aEffect)) {
                lResult = Api.Player.LevelUp.Singleton.Get(aEffect).Base.Value * Level;
            }

            // Änderung durch Charakterklasse
            Data.Misc.Aptitude.IAptitudeData? lAptitude = PlayerClass.AptitudeList.Where(x => aEffect.Equals(x.Effect)).FirstOrDefault();

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

        private int IncreaseModifierData(ModifierData aModifier, int aDefault) {
            if (aModifier.HasData) {
                return aModifier.GetValueByLevel(Level);
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