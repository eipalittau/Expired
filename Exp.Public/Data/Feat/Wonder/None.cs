using Exp.Util.Enumeration;

namespace Exp.Data.Feat.Wonder
{
    public sealed class None : WonderDataBase, IWonderData {
        #region Konstruktor
        private None()
            : base(Public.Properties.Resources.NameDefaultObject, int.MinValue, Api.General.Tier.Singleton.Get(Public.Properties.Resources.NameDefaultObject)) {
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