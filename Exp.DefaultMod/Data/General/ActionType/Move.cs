namespace Exp.DefaultMod.General.ActionType {
    public sealed class Move : ActionTypeBase, Data.General.IActionTypeData {
        #region Konstruktor
        internal Move()
            : base(nameof(Move), 2, 1) {
            Name.Set(Util.LanguageEnum.Deutsch, "Bewegungsaktion");
            Name.Set(Util.LanguageEnum.English, "Move action");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Nicht offensive Aktion");
            LoreDescription.Set(Util.LanguageEnum.English, "Non offensive Action");
        }
        #endregion
    }
}