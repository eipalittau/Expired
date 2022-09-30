using Exp.Util.Enumeration;

namespace Exp.Data.Item.Item
{
    public sealed class None : ItemDataBase, IItemData {
        #region Konstruktor
        private None()
            : base(Public.Properties.Resources.NameDefaultObject, int.MinValue,
                  Api.Item.ItemType.Singleton.Get(Public.Properties.Resources.NameDefaultObject),
                  Api.Enemy.EnemyClass.Singleton.Get(Public.Properties.Resources.NameDefaultObject), false) {
            foreach (LanguageEnum lItem in LanguageEnum.Enumerate()) {
                Name.Set(lItem, Public.Properties.Resources.NameDefaultObject);
                LoreDescription.Set(lItem, Public.Properties.Resources.NameDefaultObject);
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