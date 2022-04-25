namespace Exp.Data.General.Tier {
    internal sealed class Three : TierBase, ITierData {
        #region Konstruktor
        internal Three()
            : base(nameof(Three), 3, 3) {
            Name.Set(Util.LanguageEnum.Deutsch, "Stufe drei");
            Name.Set(Util.LanguageEnum.English, "Tier three");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}