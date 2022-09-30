using Exp.Util.Enumeration;

namespace Exp.Data.General.Tier
{
    public sealed class None : TierBase, ITierData {
        #region Konstruktor
        private None()
            : base(Public.Properties.Resources.NameDefaultObject, int.MinValue, int.MinValue, System.Drawing.Color.Black) {
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