using Exp.Util.Enumeration;

namespace Exp.Data.Item.Effect
{
    public sealed class None : EffectDataBase, IEffectData {
        #region Konstruktor
        private None()
            : base(Public.Properties.Resources.NameDefaultObject, int.MinValue) {
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