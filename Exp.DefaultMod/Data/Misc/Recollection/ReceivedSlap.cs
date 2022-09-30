using Exp.Data.Misc.Recollection;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Misc.Recollection
{
    public sealed class ReceivedSlap : RecollectionDataBase, IRecollectionData {
        #region Konstruktor
        private ReceivedSlap()
            : base(nameof(ReceivedSlap), 100, 1, 10) {
            Name.Set(LanguageEnum.Deutsch, "Ohrfeige erhalten");
            Name.Set(LanguageEnum.English, "Received slap");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new ReceivedSlap());
        }
        #endregion
    }
}