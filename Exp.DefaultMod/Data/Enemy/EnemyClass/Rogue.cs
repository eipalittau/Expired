namespace Exp.DefaultMod.Enemy {
    internal sealed class Rogue : Exp.Data.Enemy.EnemyClassBase, Exp.Data.Enemy.IEnemyClassData {
        #region Konstruktor
        internal Rogue()
            : base(nameof(Rogue), 300, 300) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schurke");
            Name.Set(Util.LanguageEnum.English, "Rogue");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}