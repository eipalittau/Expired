using Exp.Data.Enemy.EnemyClass;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Enemy.EnemyClass {
    public sealed class Fighter : EnemyClassBase, IEnemyClassData {
        #region Konstruktor
        private Fighter()
            : base(nameof(Fighter), 400, 400) {
            Name.Set(LanguageEnum.Deutsch, "Kämpfer");
            Name.Set(LanguageEnum.English, "Fighter");
            LoreDescription.Set(LanguageEnum.Deutsch, "Dumm kloppt gut.");
            LoreDescription.Set(LanguageEnum.English, "More brawn than brains.");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Fighter());
        }
        #endregion
    }
}