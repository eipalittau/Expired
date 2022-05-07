namespace Exp.DefaultMod.General.ActionType {
    public sealed class Move : Exp.Data.General.ActionTypeBase, Exp.Data.General.IActionTypeData {
        #region Konstruktor
        private Move()
            : base(nameof(Move), 2, 1) {
            Name.Set(Util.LanguageEnum.Deutsch, "Bewegungsaktion");
            Name.Set(Util.LanguageEnum.English, "Move action");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Nicht offensive Aktion");
            LoreDescription.Set(Util.LanguageEnum.English, "Non offensive Action");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Move());
        }
        #endregion
    }
}