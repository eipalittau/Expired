using Exp.Data.Player.PlayerClass;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Player.PlayerClass
{
    public sealed class Banshee : PlayerClassDataBase, IPlayerClassData {
        #region Properties / Felder
        #endregion

        #region Konstruktor
        /// <summary>
        /// Mirko: create summary EVERYWHERE !!
        /// </summary>
        private Banshee()
            : base(nameof(Banshee), 500, "Mandy", new Aptitude.LoseAction()) {

            Name.Set(LanguageEnum.Deutsch, "Todesfee");
            Name.Set(LanguageEnum.English, "Banshee");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
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