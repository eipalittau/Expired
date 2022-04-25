namespace Exp.Data.General.Tier {
    internal sealed class Two : TierBase, ITierData {
        #region Konstruktor
        internal Two()
            : base(nameof(Two), 2, 2) {
            Name.Set(Util.LanguageEnum.Deutsch, "Stufe zwei");
            Name.Set(Util.LanguageEnum.English, "Tier two");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}