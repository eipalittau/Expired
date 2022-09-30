using Exp.Data.Player.PlayerClass;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Player.PlayerClass
{
    public sealed class Zombie : PlayerClassDataBase, IPlayerClassData {
        #region Konstruktor
        private Zombie()
            : base(nameof(Zombie), 200, "Marvin", new Aptitude.Health()) {
            Name.Set(LanguageEnum.Deutsch, "Zombie");
            Name.Set(LanguageEnum.English, "Zombie");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Zombie());
        }
        #endregion
    }
}