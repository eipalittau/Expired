using Exp.Data.General.Tier;

namespace Exp.DefaultMod.General.Tier {
    public sealed class One : TierBase, ITierData {
        #region Konstruktor
        private One()
            : base(nameof(One), 1, 1, System.Drawing.Color.LimeGreen) {
            Name.Set(Util.LanguageEnum.Deutsch, "Stufe eins");
            Name.Set(Util.LanguageEnum.English, "Tier one");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new One());
        }
        #endregion
    }
}