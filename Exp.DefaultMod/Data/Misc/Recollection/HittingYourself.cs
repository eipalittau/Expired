using Exp.Data.Misc.Recollection;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Misc.Recollection
{
    public sealed class HittingYourself : RecollectionDataBase, IRecollectionData {
        #region Konstruktor
        private HittingYourself()
            : base(nameof(HittingYourself), 300, 16, 20) {
            Name.Set(LanguageEnum.Deutsch, "Warum schlägst du dich selbst?");
            Name.Set(LanguageEnum.English, "Why are you hitting yourself?");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new HittingYourself());
        }
        #endregion
    }
}