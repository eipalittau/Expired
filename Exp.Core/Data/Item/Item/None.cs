namespace Exp.Data.Item.Item {
    public sealed class None : ItemDataBase, IItemData {
        #region Konstruktor
        private None()
            : base(Core.Properties.Resources.NameDefaultObject, int.MinValue,
                  Api.Item.ItemType.Singleton.Get(Core.Properties.Resources.NameDefaultObject),
                  Api.Enemy.EnemyClass.Singleton.Get(Core.Properties.Resources.NameDefaultObject), false) {
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