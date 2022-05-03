namespace Exp.DefaultMod.Enemy {
    internal sealed class Mage : Exp.Data.Enemy.EnemyClassBase, Exp.Data.Enemy.IEnemyClassData {
        #region Konstruktor
        internal Mage()
            : base(nameof(Mage), 100, 100) {
            Name.Set(Util.LanguageEnum.Deutsch, "Magier");
            Name.Set(Util.LanguageEnum.English, "Mage");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}