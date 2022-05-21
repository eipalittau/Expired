using Exp.Data.General.Tier;

namespace Exp.DefaultMod.General.Tier {
    public sealed class Three : TierBase, ITierData {
        #region Konstruktor
        private Three()
            : base(nameof(Three), 3, 3, System.Drawing.Color.Crimson) {
            Name.Set(Util.LanguageEnum.Deutsch, "Stufe drei");
            Name.Set(Util.LanguageEnum.English, "Tier three");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Three());
        }
        #endregion
    }
}