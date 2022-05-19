namespace Exp.Data.General.ActionType {
    public sealed class None : ActionTypeBase, IActionTypeData {
        #region Konstruktor
        private None()
            : base(Core.Properties.Resources.NameDefaultObject, int.MinValue, int.MinValue) {
            foreach (Util.LanguageEnum lItem in Util.LanguageEnum.Enumerate()) {
                Name.Set(lItem, Core.Properties.Resources.NameDefaultObject);
                LoreDescription.Set(lItem, Core.Properties.Resources.NameDefaultObject);
            }
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new None());
        }
        #endregion
    }
}