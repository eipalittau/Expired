using Exp.Data.Enemy;

namespace Exp.DefaultMod.Enemy {
    internal sealed class Cleric : EnemyClassBase, IEnemyClassData {
        #region Konstruktor
        internal Cleric()
            : base(nameof(Cleric), 200, 200) {
            Name.Set(Util.LanguageEnum.Deutsch, "Kleriker");
            Name.Set(Util.LanguageEnum.English, "Cleric");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Der natürliche Feind eines jeden Untoten.");
            LoreDescription.Set(Util.LanguageEnum.English, "The natural Enemy of any undead");
        }
        #endregion
    }
}