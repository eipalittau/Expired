using Exp.Data.General.Tier;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.General.Tier
{
    public sealed class Three : TierBase, ITierData {
        #region Konstruktor
        private Three()
            : base(nameof(Three), 3, 3, System.Drawing.Color.Crimson) {
            Name.Set(LanguageEnum.Deutsch, "Stufe drei");
            Name.Set(LanguageEnum.English, "Tier three");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Three());
        }
        #endregion
    }
}