using Exp.Api.Player;
using Exp.Data.Player;
using Exp.Util;

namespace Exp.Api {
    public sealed class Main {
        #region Properties / Felder
        private static Main Singleton { get; } = new();
        public int Experience { get; private set; }
        private bool IsInitialized { get; set; }
        #endregion

        #region Konstruktor
        private Main() { }
        #endregion

        #region Methoden
        public void Initialize(int aExperience4LevelUp, bool aThrowException, LanguageEnum aLanguage) {
            try {
                Experience = aExperience4LevelUp;

                Localisation.AddResourceFile("Labeling.Labeling");
                SetLanguage(aLanguage);
                ExceptionHandler.ThrowException = aThrowException;

                IsInitialized = true;
            } catch (System.Exception aEx) {

            }
        }

        public CharacterSheet CreateCharacter() {
            if (IsInitialized) {
                return CharacterSheet.Create(Experience);
            } else {
                throw new Exception.MissingInitializationException();
            }
        }

        public CharacterSheet CreateCharacter(IPlayerClassData aPlayerClass) {
            if (IsInitialized) {
                return CharacterSheet.Create(aPlayerClass, Experience);
            } else {
                throw new Exception.MissingInitializationException();
            }
        }

        public void SetLanguage(LanguageEnum aLanguage) {
            Localisation.Language = aLanguage;
        }
        #endregion
    }
}