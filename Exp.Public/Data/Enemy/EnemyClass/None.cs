using Exp.Util.Enumeration;

namespace Exp.Data.Enemy.EnemyClass
{
    public sealed class None : EnemyClassBase, IEnemyClassData {
        #region Konstruktor
        private None()
            : base(Public.Properties.Resources.NameDefaultObject, int.MinValue, int.MinValue) {
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