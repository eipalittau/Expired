namespace Exp.DefaultMod.Enemy.EnemyClass {
    public sealed class Mage : Exp.Data.Enemy.EnemyClassBase, Exp.Data.Enemy.IEnemyClassData {
        #region Konstruktor
        private Mage()
            : base(nameof(Mage), 100, 100) {
            Name.Set(Util.LanguageEnum.Deutsch, "Magier");
            Name.Set(Util.LanguageEnum.English, "Mage");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Mage());
        }
        #endregion
    }
}