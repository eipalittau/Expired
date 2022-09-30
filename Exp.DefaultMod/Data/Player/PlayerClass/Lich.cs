using Exp.Data.Player.PlayerClass;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Player.PlayerClass
{
    public sealed class Lich : PlayerClassDataBase, IPlayerClassData {
        #region Konstruktor
        private Lich()
            : base(nameof(Lich), 600, "Jacqueline", new Aptitude.Mana()) {
            Name.Set(LanguageEnum.Deutsch, "Lich");
            Name.Set(LanguageEnum.English, "Lich");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Lich());
        }
        #endregion
    }
}