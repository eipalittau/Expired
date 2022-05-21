using Exp.Data.General.Tier;

namespace Exp.DefaultMod.General.Tier {
    public sealed class Two : TierBase, ITierData {
        #region Konstruktor
        private Two()
            : base(nameof(Two), 2, 2, System.Drawing.Color.Yellow) {
            Name.Set(Util.LanguageEnum.Deutsch, "Stufe zwei");
            Name.Set(Util.LanguageEnum.English, "Tier two");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Two());
        }
        #endregion
    }
}