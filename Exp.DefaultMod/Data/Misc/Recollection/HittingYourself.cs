namespace Exp.DefaultMod.Misc.Recollection {
    public sealed class HittingYourself : Exp.Data.Misc.RecollectionDataBase, Exp.Data.Misc.IRecollectionData {
        #region Konstruktor
        private HittingYourself()
            : base(nameof(HittingYourself), 300, 16, 20) {
            Name.Set(Util.LanguageEnum.Deutsch, "Warum schlägst du dich selbst?");
            Name.Set(Util.LanguageEnum.English, "Why are you hitting yourself?");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new HittingYourself());
        }
        #endregion
    }
}