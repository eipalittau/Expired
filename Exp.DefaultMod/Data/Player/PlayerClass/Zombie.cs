namespace Exp.DefaultMod.Player.PlayerClass {
    internal sealed class Zombie : Exp.Data.Player.PlayerClassDataBase, Exp.Data.Player.IPlayerClassData {
        #region Konstruktor
        internal Zombie()
            : base(nameof(Zombie), 200, "Marvin") {
            Name.Set(Util.LanguageEnum.Deutsch, "Zombie");
            Name.Set(Util.LanguageEnum.English, "Zombie");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}