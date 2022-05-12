using Exp.Api.Player;
using Exp.Data.Player;
using Exp.Exception;
using Exp.Util;

namespace Exp.Api {
    public sealed class Main {
        #region Properties / Felder
        public static Main Singleton { get; } = new();
        public int Experience { get; private set; }
        #endregion

        public void Initialize(int aExperience4LevelUp, bool aThrowException) {
            Experience = aExperience4LevelUp;

            Localisation.AddResourceFile("Labeling.Labeling");
            Localisation.Language = LanguageEnum.Deutsch;
            ExceptionHandler.ThrowException = aThrowException;
        }

        public CharacterSheet Create() {
            return CharacterSheet.Create(Experience);
        }

        public CharacterSheet Create(IPlayerClassData aPlayerClass) {
            return CharacterSheet.Create(aPlayerClass, Experience);
        }
    }
}