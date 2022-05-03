namespace Exp.DefaultMod.Player.PlayerClass {
    internal sealed class Vampire : Exp.Data.Player.PlayerClassDataBase, Exp.Data.Player.IPlayerClassData {
        #region Konstruktor
        internal Vampire()
            : base(nameof(Vampire), 400, "Chantal") {
            Name.Set(Util.LanguageEnum.Deutsch, "Vampir");
            Name.Set(Util.LanguageEnum.English, "Vampire");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}