using Exp.Data.Player.PlayerClass;

namespace Exp.DefaultMod.Player.PlayerClass {
    public sealed class Vampire : PlayerClassDataBase, IPlayerClassData {
        #region Konstruktor
        private Vampire()
            : base(nameof(Vampire), 400, "Chantal", new Aptitude.Movement()) {
            Name.Set(Util.LanguageEnum.Deutsch, "Vampir");
            Name.Set(Util.LanguageEnum.English, "Vampire");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Vampire());
        }
        #endregion
    }
}