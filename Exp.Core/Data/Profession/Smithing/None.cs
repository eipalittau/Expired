namespace Exp.Data.Profession.Smithing {
    public sealed class None : SmithingDataBase, ISmithingData {
        #region Konstruktor
        private None()
            : base(Core.Properties.Resources.NameDefaultObject, int.MinValue,
                  Api.General.Tier.Singleton.Get(Core.Properties.Resources.NameDefaultObject),
                  Api.Item.ItemType.Singleton.Get(Core.Properties.Resources.NameDefaultObject)) {

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