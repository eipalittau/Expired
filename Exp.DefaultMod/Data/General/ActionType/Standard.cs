namespace Exp.DefaultMod.General.ActionType {
    public sealed class Standard : ActionTypeBase, Data.General.IActionTypeData {
        #region Konstruktor
        internal Standard()
            : base(nameof(Standard), 3, 1.5) {
            Name.Set(Util.LanguageEnum.Deutsch, "Standard Aktion");
            Name.Set(Util.LanguageEnum.English, "Standard action");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Offensive Aktion.");
            LoreDescription.Set(Util.LanguageEnum.English, "Offensive action.");
        }
        #endregion
    }
}