namespace Exp.Data.General.Tier {
    public sealed class Three : TierBase, ITierData {
        #region Konstruktor
        internal Three()
            : base(nameof(Three), 3, 3) {
            Name.Set(Util.LanguageEnum.Deutsch, "Stufe drei");
            Name.Set(Util.LanguageEnum.English, "Tier three");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}