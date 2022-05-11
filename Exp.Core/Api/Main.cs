namespace Exp.Api {
    public sealed class Main {
        #region Properties / Felder
        public static Main Singleton { get; } = new();
        public int Experience { get; private set; }
        #endregion

        public void Initialize(int aExperience4LevelUp) {
            Experience = aExperience4LevelUp;

            Exp.Util.Localisation.AddResourceFile("Labeling.Labeling");
            Exp.Util.Localisation.Language = Exp.Util.LanguageEnum.Deutsch;
        }

        public Player.CharacterSheet Create() {
            return Player.CharacterSheet.Create(Experience);
        }

        public Player.CharacterSheet Create(Data.Player.IPlayerClassData aPlayerClass) {
            return Player.CharacterSheet.Create(aPlayerClass, Experience);
        }
    }
}