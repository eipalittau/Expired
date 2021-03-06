using Exp.Data.Player.PlayerClass;

namespace Exp.DefaultMod.Player.PlayerClass {
    public sealed class Banshee : PlayerClassDataBase, IPlayerClassData {
        #region Properties / Felder
        #endregion

        #region Konstruktor
        /// <summary>
        /// Mirko: create summary EVERYWHERE !!
        /// </summary>
        private Banshee()
            : base(nameof(Banshee), 500, "Mandy", new Aptitude.LoseAction()) {

            Name.Set(Util.LanguageEnum.Deutsch, "Todesfee");
            Name.Set(Util.LanguageEnum.English, "Banshee");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        /// <summary>
        /// blablabla
        /// </summary>
        public static void Add() {
            AddInstance(new Banshee());
        }
        #endregion
    }
}