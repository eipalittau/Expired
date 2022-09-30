using Exp.Data.Misc.Recollection;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Misc.Recollection
{
    public sealed class BeenPushed : RecollectionDataBase, IRecollectionData {
        #region Konstruktor
        private BeenPushed()
            : base(nameof(BeenPushed), 200, 11, 15) {
            Name.Set(LanguageEnum.Deutsch, "Geschubst worden");
            Name.Set(LanguageEnum.English, "Been pushed");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new BeenPushed());
        }
        #endregion
    }
}