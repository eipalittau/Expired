using Exp.Data.Misc.Recollection;

namespace Exp.DefaultMod.Misc.Recollection {
    public sealed class BeenPushed : RecollectionDataBase, IRecollectionData {
        #region Konstruktor
        private BeenPushed()
            : base(nameof(BeenPushed), 200, 11, 15) {
            Name.Set(Util.LanguageEnum.Deutsch, "Geschubst worden");
            Name.Set(Util.LanguageEnum.English, "Been pushed");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new BeenPushed());
        }
        #endregion
    }
}