namespace Exp.DefaultMod.General.Tier {
    public sealed class Three : Exp.Data.General.TierBase, Exp.Data.General.ITierData {
        #region Konstruktor
        private Three()
            : base(nameof(Three), 3, 3) {
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