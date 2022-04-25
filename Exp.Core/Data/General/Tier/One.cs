namespace Exp.Data.General.Tier {
    internal sealed class One : TierBase, ITierData {
        #region Konstruktor
        internal One()
            : base(nameof(One), 1, 1) {
            Name.Set(Util.LanguageEnum.Deutsch, "Stufe eins");
            Name.Set(Util.LanguageEnum.English, "Tier one");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}