using Exp.Data.General.Tier;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.General.Tier
{
    public sealed class Two : TierBase, ITierData {
        #region Konstruktor
        private Two()
            : base(nameof(Two), 2, 2, System.Drawing.Color.Yellow) {
            Name.Set(LanguageEnum.Deutsch, "Stufe zwei");
            Name.Set(LanguageEnum.English, "Tier two");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Two());
        }
        #endregion
    }
}