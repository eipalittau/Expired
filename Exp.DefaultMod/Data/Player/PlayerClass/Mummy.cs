using Exp.Data.Player.PlayerClass;

namespace Exp.DefaultMod.Player.PlayerClass {
    public sealed class Mummy : PlayerClassDataBase, IPlayerClassData {
        #region Konstruktor
        private Mummy()
            : base(nameof(Mummy), 300, "Justin", new Aptitude.Skill()) {
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