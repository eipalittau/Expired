namespace Exp.DefaultMod.Misc.Recollection {
    public sealed class RippedOff : Exp.Data.Misc.RecollectionDataBase, Exp.Data.Misc.IRecollectionData {
        #region Konstruktor
        private RippedOff()
            : base(nameof(RippedOff), 300, 26, 30) {
            Name.Set(Util.LanguageEnum.Deutsch, "Ein Mentalist hat dich abgezockt");
            Name.Set(Util.LanguageEnum.English, "A mentalist ripped you off");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new RippedOff());
        }
        #endregion
    }
}
