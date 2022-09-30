using Exp.Data.Misc.Recollection;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Misc.Recollection
{
    public sealed class RippedOff : RecollectionDataBase, IRecollectionData {
        #region Konstruktor
        private RippedOff()
            : base(nameof(RippedOff), 500, 26, 30) {
            Name.Set(LanguageEnum.Deutsch, "Ein Mentalist hat dich abgezockt");
            Name.Set(LanguageEnum.English, "A mentalist ripped you off");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new RippedOff());
        }
        #endregion
    }
}
