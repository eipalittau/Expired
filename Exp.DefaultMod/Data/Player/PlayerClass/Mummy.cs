namespace Exp.DefaultMod.Player.PlayerClass {
    public sealed class Mummy : Exp.Data.Player.PlayerClassDataBase, Exp.Data.Player.IPlayerClassData {
        #region Konstruktor
        private Mummy()
            : base(nameof(Mummy), 300, "Justin") {
            Name.Set(Util.LanguageEnum.Deutsch, "Mumie");
            Name.Set(Util.LanguageEnum.English, "Mummy");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Mummy());
        }
        #endregion
    }
}