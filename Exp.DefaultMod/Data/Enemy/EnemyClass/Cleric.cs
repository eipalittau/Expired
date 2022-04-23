using Exp.Data.Enemy;

namespace Exp.DefaultMod.Enemy {
    internal sealed class Cleric : EnemyClassBase, IEnemyClassData {
        #region Konstruktor
        internal Cleric()
            : base(nameof(Cleric), 200, 200) {
            Name.Set(Util.LanguageEnum.Deutsch, "Kleriker");
            Name.Set(Util.LanguageEnum.English, "Cleric");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}