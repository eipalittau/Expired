using Exp.Api.Player;
using Exp.Data.Player;
using Exp.Util;

namespace Exp.Api {
    public sealed class Main {
        #region Properties / Felder
        public int Experience { get; private set; }
        #endregion

        #region Konstruktor
        public Main(bool aThrowException, LanguageEnum aLanguage) {
            try {
                Localisation.AddResourceFile("Labeling.Labeling");
                SetLanguage(aLanguage);
                ExceptionHandler.ThrowException = aThrowException;
            } catch (System.Exception aEx) {

            }
        }
        #endregion

        #region Methoden
        public CharacterSheet CreateCharacter() {
            return CharacterSheet.Create(Experience);
        }

        public CharacterSheet CreateCharacter(IPlayerClassData aPlayerClass) {
            return CharacterSheet.Create(aPlayerClass, Experience);
        }

        public void SetLanguage(LanguageEnum aLanguage) {
            Localisation.Language = aLanguage;
        }

        public void SetExperience4LevelUp(int aValue) {
            Experience = aValue;
        }
        #endregion
    }
}