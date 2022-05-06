using Exp.Data.Enemy;

namespace Exp.DefaultMod.Enemy {
    internal sealed class Rogue : EnemyClassBase, IEnemyClassData {
        #region Konstruktor
        internal Rogue()
            : base(nameof(Rogue), 300, 300) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schurke");
            Name.Set(Util.LanguageEnum.English, "Rogue");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Das spitze Ende geht in den Gegner.");
            LoreDescription.Set(Util.LanguageEnum.English, "The pointy end goes into the enemy.");
        }
        #endregion
    }
}