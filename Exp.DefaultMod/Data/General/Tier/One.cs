using Exp.Data.General.Tier;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.General.Tier
{
    public sealed class One : TierBase, ITierData {
        #region Konstruktor
        private One()
            : base(nameof(One), 1, 1, System.Drawing.Color.LimeGreen) {
            Name.Set(LanguageEnum.Deutsch, "Stufe eins");
            Name.Set(LanguageEnum.English, "Tier one");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new One());
        }
        #endregion
    }
}