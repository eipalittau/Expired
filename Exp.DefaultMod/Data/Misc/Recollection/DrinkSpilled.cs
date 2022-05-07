namespace Exp.DefaultMod.Misc.Recollection {
    public sealed class DrinkSpilled : Exp.Data.Misc.RecollectionDataBase, Exp.Data.Misc.IRecollectionData {
        #region Konstruktor
        private DrinkSpilled()
            : base(nameof(DrinkSpilled), 400, 21, 25) {
            Name.Set(Util.LanguageEnum.Deutsch, "Getränk verschüttet");
            Name.Set(Util.LanguageEnum.English, "Drink spilled");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new DrinkSpilled());
        }
        #endregion
    }
}
