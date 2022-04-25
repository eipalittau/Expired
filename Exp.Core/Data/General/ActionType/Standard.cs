namespace Exp.Data.General.ActionType {
    internal sealed class Standard : ActionTypeBase, IActionTypeData {
        #region Konstruktor
        internal Standard()
            : base(nameof(Standard), 3, 1.5) {
            Name.Set(Util.LanguageEnum.Deutsch, "Standard Aktion");
            Name.Set(Util.LanguageEnum.English, "Standard action");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}