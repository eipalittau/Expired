using Exp.Data.Player.PlayerClass;

namespace Exp.DefaultMod.Player.PlayerClass {
    public sealed class Lich : PlayerClassDataBase, IPlayerClassData {
        #region Konstruktor
        private Lich()
            : base(nameof(Lich), 600, "Jacqueline", new Aptitude.Mana()) {
            Name.Set(Util.LanguageEnum.Deutsch, "Lich");
            Name.Set(Util.LanguageEnum.English, "Lich");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Lich());
        }
        #endregion
    }
}