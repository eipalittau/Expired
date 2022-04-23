using Exp.Data.Enemy;

namespace Exp.DefaultMod.Enemy {
    internal sealed class Fighter : EnemyClassBase, IEnemyClassData {
        #region Konstruktor
        internal Fighter()
            : base(nameof(Fighter), 400, 400) {
            Name.Set(Util.LanguageEnum.Deutsch, "Kämpfer");
            Name.Set(Util.LanguageEnum.English, "Fighter");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}