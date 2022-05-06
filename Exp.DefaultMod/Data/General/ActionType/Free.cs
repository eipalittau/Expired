namespace Exp.DefaultMod.General.ActionType {
    public sealed class Free : ActionTypeBase, Data.General.IActionTypeData {
        #region Konstruktor
        internal Free()
            : base(nameof(Free), 1, 0) {
            Name.Set(Util.LanguageEnum.Deutsch, "Freie Aktion");
            Name.Set(Util.LanguageEnum.English, "Free action");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Jede Freie Aktion kann ein Mal pro Runde angewendet werden.");
            LoreDescription.Set(Util.LanguageEnum.English, "Each Free Action can be taken once per turn.");
        }
        #endregion
    }
}