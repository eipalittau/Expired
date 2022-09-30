using Exp.Util.Enumeration;

namespace Exp.Data.Player.LevelUp
{
    public sealed class None : LevelUpDataBase, ILevelUpData {
        #region Konstruktor
        private None()
            : base(Api.General.TargetEffectEnum.None, new Api.Helper.ModifierData(int.MinValue, int.MinValue, int.MinValue)) {
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