namespace Exp.Data.Misc.Recollection {
    public sealed class None : RecollectionDataBase, IRecollectionData {
        #region Konstruktor
        private None()
            : base(Core.Properties.Resources.NameDefaultObject, int.MinValue, int.MinValue, int.MinValue) {
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