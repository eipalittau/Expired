namespace Exp.DefaultMod.Player.PlayerClass {
    public sealed class Cerberus : Exp.Data.Player.PlayerClassDataBase, Exp.Data.Player.IPlayerClassData {
        #region Konstruktor
        private Cerberus()
            : base(nameof(Cerberus), 800, "Kitty") {
            Name.Set(Util.LanguageEnum.Deutsch, "Zerberus");
            Name.Set(Util.LanguageEnum.English, "Cerberus");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Cerberus());
        }
        #endregion
    }
}