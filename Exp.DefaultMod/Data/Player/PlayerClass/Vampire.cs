using Exp.Data.Player.PlayerClass;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Player.PlayerClass
{
    public sealed class Vampire : PlayerClassDataBase, IPlayerClassData {
        #region Konstruktor
        private Vampire()
            : base(nameof(Vampire), 400, "Chantal", new Aptitude.Movement()) {
            Name.Set(LanguageEnum.Deutsch, "Vampir");
            Name.Set(LanguageEnum.English, "Vampire");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Vampire());
        }
        #endregion
    }
}