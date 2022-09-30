using Exp.Data.Misc.Recollection;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Misc.Recollection
{
    public sealed class DrinkSpilled : RecollectionDataBase, IRecollectionData {
        #region Konstruktor
        private DrinkSpilled()
            : base(nameof(DrinkSpilled), 400, 21, 25) {
            Name.Set(LanguageEnum.Deutsch, "Getränk verschüttet");
            Name.Set(LanguageEnum.English, "Drink spilled");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new DrinkSpilled());
        }
        #endregion
    }
}
