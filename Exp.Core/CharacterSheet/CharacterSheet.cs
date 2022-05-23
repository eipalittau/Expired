using Exp.Api.General;
using Exp.Api.Helper;

namespace Exp.Core {
    public sealed class CharacterSheet : Data.Player.ICharacterSheetData {
        #region Properties / Felder
        public bool IsDead { get; internal set; } = true;
        public Data.Player.PlayerClass.IPlayerClassData PlayerClass { get; init; }
        public Sheet.ExperienceData Experience { get; init; }
        public Sheet.HealthData Health { get; init; }
        public Sheet.ArmorClassData ArmorClass { get; init; }
        public Sheet.ResistenceData Resistence { get; init; }
        public Sheet.AttackData Attack { get; init; }
        public Sheet.DamageData Damage { get; init; }
        public Sheet.SneakyData Sneaky { get; init; }
        public Sheet.ConjureData Conjure { get; init; }
        public Sheet.MovementData Movement { get; init; }
        public Sheet.FeatData Feat { get; init; }
        public Sheet.SkillData Skill { get; init; }
        public Sheet.SmithingData Smithing { get; init; }
        public IList<Sheet.EquipmentData> EquipmentList { get; } = new List<Sheet.EquipmentData>();
        public IList<Data.Misc.Recollection.IRecollectionData> RecollectionList { get; } = new List<Data.Misc.Recollection.IRecollectionData>();
        #endregion

        #region Konstruktor
        private CharacterSheet(Data.Player.PlayerClass.IPlayerClassData aPlayerClass, int aExperience4LevelUp) { 
            PlayerClass = aPlayerClass;
            Experience = new(this, aExperience4LevelUp);
            Health = new Sheet.HealthData(this);
            ArmorClass = new Sheet.ArmorClassData(this);
            Resistence = new Sheet.ResistenceData(this);
            Attack = new Sheet.AttackData(this);
            Damage = new Sheet.DamageData(this);
            Sneaky = new Sheet.SneakyData(this);
            Conjure = new Sheet.ConjureData(this);
            Movement = new Sheet.MovementData(this);
            Feat = new Sheet.FeatData(10);
            Skill = new Sheet.SkillData(int.MaxValue);
            Smithing = new Sheet.SmithingData(5);
            
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
        public bool LevelUp() {
            if (Experience.LevelUp()) {
                Health.LevelUp();
                ArmorClass.LevelUp();
                Resistence.LevelUp();
                Attack.LevelUp();
                Damage.LevelUp();
                Sneaky.LevelUp();
                Conjure.LevelUp();
                Movement.LevelUp();
                Feat.SetFeatPoints();
                Skill.SetSkillPoints();
                Smithing.SetSmithingPoints();

                return true;
            } else {
                return false;
            }
        }

        //Mirko: Wirklich?
        public void AddFeat(Data.Feat.IFeatDataBase aFeat) {
            Feat.LevelUp(aFeat);
        }

        //Mirko: Wirklich?
        public void AddSkill(Data.Skill.SkillType.ISkillTypeData aSkill) {
            Skill.LevelUp(aSkill);
        }
        //Patrik: Neue Methode für Beruf und Erinnerungen.
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