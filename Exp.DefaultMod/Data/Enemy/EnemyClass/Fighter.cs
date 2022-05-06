using Exp.Data.Enemy;

namespace Exp.DefaultMod.Enemy {
    internal sealed class Fighter : EnemyClassBase, IEnemyClassData {
        #region Konstruktor
        internal Fighter()
            : base(nameof(Fighter), 400, 400) {
            Name.Set(Util.LanguageEnum.Deutsch, "Kämpfer");
            Name.Set(Util.LanguageEnum.English, "Fighter");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Dumm kloppt gut.");
            LoreDescription.Set(Util.LanguageEnum.English, "More brawn than brains.");
        }
        #endregion
    }
}