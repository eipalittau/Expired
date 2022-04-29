namespace Exp.DefaultMod.General.Tier {
    public sealed class Two : TierBase, Data.General.ITierData {
        #region Konstruktor
        internal Two()
            : base(nameof(Two), 2, 2) {
            Name.Set(Util.LanguageEnum.Deutsch, "Stufe zwei");
            Name.Set(Util.LanguageEnum.English, "Tier two");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}