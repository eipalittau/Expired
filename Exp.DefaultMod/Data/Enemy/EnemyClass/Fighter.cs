using Exp.Data.Enemy.EnemyClass;

namespace Exp.DefaultMod.Enemy.EnemyClass {
    public sealed class Fighter : EnemyClassBase, IEnemyClassData {
        #region Konstruktor
        private Fighter()
            : base(nameof(Fighter), 400, 400) {
            Name.Set(Util.LanguageEnum.Deutsch, "Kämpfer");
            Name.Set(Util.LanguageEnum.English, "Fighter");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Dumm kloppt gut.");
            LoreDescription.Set(Util.LanguageEnum.English, "More brawn than brains.");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Fighter());
        }
        #endregion
    }
}