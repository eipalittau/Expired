namespace Exp.Data.General.ActionType {
    public sealed class Move : ActionTypeBase, IActionTypeData {
        #region Konstruktor
        internal Move()
            : base(nameof(Move), 2, 1) {
            Name.Set(Util.LanguageEnum.Deutsch, "Bewegungsaktion");
            Name.Set(Util.LanguageEnum.English, "Move action");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}