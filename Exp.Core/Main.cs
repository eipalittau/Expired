using Exp.Api.Player;
using Exp.Util;

namespace Exp.Core {
    public sealed class Main {
        #region Properties / Felder
        public int Experience { get; private set; }
        #endregion

        #region Konstruktor
        public Main(LanguageEnum aLanguage, bool aThrowException) {
            try {
                ExceptionHandler.ThrowException = aThrowException;
                Localisation.AddResourceFile("Labeling.Labeling");
                SetLanguage(aLanguage);

            } catch (System.Exception aEx) {

            }
        }
        #endregion

        #region Methoden
        public CharacterSheet CreateCharacter() {
            return CharacterSheet.Create(Experience);
        }

        public CharacterSheet CreateCharacter(Data.Player.PlayerClass.IPlayerClassData aPlayerClass) {
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