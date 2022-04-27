namespace Exp.Data.General.DamageType {
    public sealed class Magic : DamageTypeBase, IDamageTypeData {
        #region Konstruktor
        internal Magic()
            : base(nameof(Magic), 3) {
            Name.Set(Util.LanguageEnum.Deutsch, "Magie");
            Name.Set(Util.LanguageEnum.English, "Magic");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}
