namespace Exp.DefaultMod.General.ActionType {
    public sealed class Free : Exp.Data.General.ActionTypeBase, Exp.Data.General.IActionTypeData {
        #region Konstruktor
        internal Free()
            : base(nameof(Free), 1, 0) {
            Name.Set(Util.LanguageEnum.Deutsch, "Freie Aktion");
            Name.Set(Util.LanguageEnum.English, "Free action");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}