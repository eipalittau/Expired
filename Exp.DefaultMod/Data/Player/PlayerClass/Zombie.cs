namespace Exp.DefaultMod.Player.PlayerClass {
    public sealed class Zombie : Exp.Data.Player.PlayerClassDataBase, Exp.Data.Player.IPlayerClassData {
        #region Konstruktor
        private Zombie()
            : base(nameof(Zombie), 200, "Marvin", new Aptitude.Health()) {
            Name.Set(Util.LanguageEnum.Deutsch, "Zombie");
            Name.Set(Util.LanguageEnum.English, "Zombie");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Zombie());
        }
        #endregion
    }
}