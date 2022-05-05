namespace Exp.DefaultMod.Enemy.EnemyClass {
    public sealed class Fighter : Exp.Data.Enemy.EnemyClassBase, Exp.Data.Enemy.IEnemyClassData {
        #region Konstruktor
        private Fighter()
            : base(nameof(Fighter), 400, 400) {
            Name.Set(Util.LanguageEnum.Deutsch, "Kämpfer");
            Name.Set(Util.LanguageEnum.English, "Fighter");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Fighter());
        }
        #endregion
    }
}