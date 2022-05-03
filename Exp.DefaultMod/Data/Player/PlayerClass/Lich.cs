namespace Exp.DefaultMod.Player.PlayerClass {
    internal sealed class Lich : Exp.Data.Player.PlayerClassDataBase, Exp.Data.Player.IPlayerClassData {
        #region Konstruktor
        internal Lich()
            : base(nameof(Lich), 600, "Jacqueline") {
            Name.Set(Util.LanguageEnum.Deutsch, "Lich");
            Name.Set(Util.LanguageEnum.English, "Lich");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}