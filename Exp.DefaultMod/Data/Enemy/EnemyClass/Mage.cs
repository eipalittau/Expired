using Exp.Data.Enemy;

namespace Exp.DefaultMod.Enemy {
    internal sealed class Mage : EnemyClassBase, IEnemyClassData {
        #region Konstruktor
        internal Mage()
            : base(nameof(Mage), 100, 100) {
            Name.Set(Util.LanguageEnum.Deutsch, "Magier");
            Name.Set(Util.LanguageEnum.English, "Mage");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}