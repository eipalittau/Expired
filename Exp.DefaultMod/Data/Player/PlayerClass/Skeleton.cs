namespace Exp.DefaultMod.Player.PlayerClass {
    public sealed class Skeleton : Data.Player.PlayerClassDataBase, Data.Player.IPlayerClassData {
        #region Konstruktor
        private Skeleton()
            : base(nameof(Skeleton), 100, "Kevin", new Aptitude.ArmorClass()) {
            Name.Set(Util.LanguageEnum.Deutsch, "Skelett");
            Name.Set(Util.LanguageEnum.English, "Skeleton");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Skeleton());
        }
        #endregion
    }
}