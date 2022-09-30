using Exp.Util.Enumeration;

namespace Exp.Data.Profession.Smithing
{
    public sealed class None : SmithingDataBase, ISmithingData {
        #region Konstruktor
        private None()
            : base(Public.Properties.Resources.NameDefaultObject, int.MinValue,
                  Api.General.Tier.Singleton.Get(Public.Properties.Resources.NameDefaultObject),
                  Api.Item.ItemType.Singleton.Get(Public.Properties.Resources.NameDefaultObject)) {

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