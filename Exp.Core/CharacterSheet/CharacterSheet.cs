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
        public Sheet.EquipmentData Equipment { get; init; }
        public Sheet.RecollectionData Recollection { get; init; }
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
            Skill = new Sheet.SkillData(this, int.MaxValue);
            Smithing = new Sheet.SmithingData(5);
            Equipment = new Sheet.EquipmentData(this);
            Recollection = new Sheet.RecollectionData(this);

            RaiseAfterCharacterCreated(new EventArgs.AfterCharacterCreatedEventArgs(aPlayerClass));
        }
        #endregion

        #region Methoden
        #region Create
        public static CharacterSheet Create(int aExperience4LevelUp) {
            return new(Api.Player.PlayerClass.Singleton.GetRandom(), aExperience4LevelUp);
        }

        public static CharacterSheet Create(Data.Player.PlayerClass.IPlayerClassData aPlayerClass, int aExperience4LevelUp) {
            return new(aPlayerClass, aExperience4LevelUp);
        }
        #endregion

        #region LevelUp
        public void LevelUp() {
            bool lExecute = Experience.LevelUp();

            if (lExecute) {
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

                // Equipment: Keine Änderung durch Level-Up.
                // Recollection: Keine Änderung durch Level-Up.
            }
            
            RaiseOnLevelUp(new EventArgs.OnLevelUpEventArgs(lExecute));
        }

        //Patrik: Neue Methode für Beruf und Erinnerungen.
        #endregion

        public void OnNewDay() {
            RaiseBeforeNewDay(new EventArgs.BeforeNewDayEventArgs());
            IsDead = false;

            Health.OnNewDay();
            ArmorClass.OnNewDay();
            Resistence.OnNewDay();
            Attack.OnNewDay();
            Damage.OnNewDay();
            Sneaky.OnNewDay();
            Conjure.OnNewDay();
            Movement.OnNewDay();
            RaiseAfterNewDay(new EventArgs.AfterNewDayEventArgs());
        }
        #endregion

        #region Events
        #region Recollection
        public event EventHandler<EventArgs.NewRecollectionEventArgs>? NewRecollection;

        internal void RaiseNewRecollection(EventArgs.NewRecollectionEventArgs aArgs) {
            NewRecollection?.Invoke(this, aArgs);
        }
        #endregion

        #region CharacterCreated
        public event EventHandler<EventArgs.AfterCharacterCreatedEventArgs>? AfterCharacterCreated;

        internal void RaiseAfterCharacterCreated(EventArgs.AfterCharacterCreatedEventArgs aArgs) {
            AfterCharacterCreated?.Invoke(this, aArgs);
        }
        #endregion

        #region OnLevelUp
        public event EventHandler<EventArgs.OnLevelUpEventArgs>? OnLevelUp;

        internal void RaiseOnLevelUp(EventArgs.OnLevelUpEventArgs aArgs) {
            OnLevelUp?.Invoke(this, aArgs);
        }
        #endregion

        #region NewDay
        public event EventHandler<EventArgs.BeforeNewDayEventArgs>? BeforeNewDay;
        public event EventHandler<EventArgs.AfterNewDayEventArgs>? AfterNewDay;

        internal void RaiseBeforeNewDay(EventArgs.BeforeNewDayEventArgs aArgs) {
            BeforeNewDay?.Invoke(this, aArgs);
        }

        internal void RaiseAfterNewDay(EventArgs.AfterNewDayEventArgs aArgs) {
            AfterNewDay?.Invoke(this, aArgs);
        }
        #endregion
        #endregion
    }
}
