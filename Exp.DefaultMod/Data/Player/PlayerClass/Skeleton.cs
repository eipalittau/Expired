namespace Exp.DefaultMod.Player.PlayerClass {
    internal sealed class Skeleton : Exp.Data.Player.PlayerClassDataBase, Exp.Data.Player.IPlayerClassData {
        #region Konstruktor
        internal Skeleton()
            : base(nameof(Skeleton), 100, "Kevin") {
            Name.Set(Util.LanguageEnum.Deutsch, "Skelett");
            Name.Set(Util.LanguageEnum.English, "Skeleton");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}