namespace Exp.DefaultMod.Player.PlayerClass {
    public sealed class Banshee : Exp.Data.Player.PlayerClassDataBase, Exp.Data.Player.IPlayerClassData {
        #region Konstruktor
        private Banshee()
            : base(nameof(Banshee), 500, "Mandy") {
            Name.Set(Util.LanguageEnum.Deutsch, "Todesfee");
            Name.Set(Util.LanguageEnum.English, "Banshee");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Banshee());
        }
        #endregion
    }
}