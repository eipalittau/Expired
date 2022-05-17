using Exp.Data.Misc.Recollection;

namespace Exp.DefaultMod.Misc.Recollection {
    public sealed class ReceivedSlap : RecollectionDataBase, IRecollectionData {
        #region Konstruktor
        private ReceivedSlap()
            : base(nameof(ReceivedSlap), 100, 1, 10) {
            Name.Set(Util.LanguageEnum.Deutsch, "Ohrfeige erhalten");
            Name.Set(Util.LanguageEnum.English, "Received slap");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new ReceivedSlap());
        }
        #endregion
    }
}