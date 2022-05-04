namespace Exp.DefaultMod.Enemy {
    public sealed class Cleric : Exp.Data.Enemy.EnemyClassBase, Exp.Data.Enemy.IEnemyClassData {
        #region Konstruktor
        private Cleric()
            : base(nameof(Cleric), 200, 200) {
            Name.Set(Util.LanguageEnum.Deutsch, "Kleriker");
            Name.Set(Util.LanguageEnum.English, "Cleric");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
            
        #region Methoden
        public static void Add() {
            new Cleric().AddInstance();
        }
        #endregion
    }
}
