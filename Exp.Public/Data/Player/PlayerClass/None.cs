namespace Exp.Data.Player.PlayerClass {
    public sealed class None : PlayerClassDataBase, IPlayerClassData {
        #region Konstruktor
        private None()
            : base(Core.Properties.Resources.NameDefaultObject, int.MinValue, Core.Properties.Resources.NameDefaultObject) {
            foreach (Util.LanguageEnum lItem in Util.LanguageEnum.Enumerate()) {
                Name.Set(lItem, Core.Properties.Resources.NameDefaultObject);
                LoreDescription.Set(lItem, Core.Properties.Resources.NameDefaultObject);
            }
        }
        #endregion

        #region Methoden
        internal static void Add() {
            AddInstance(new None());
        }
        #endregion
    }
}