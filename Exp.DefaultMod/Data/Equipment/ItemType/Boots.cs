using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.ItemType {
    internal sealed class Boots : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal Boots()
            : base(nameof(Boots), 200, null, Api.Equipment.Slot.Singleton.Get("Feet")) {
            Name.Set(Util.LanguageEnum.Deutsch, "Stiefel");
            Name.Set(Util.LanguageEnum.English, "Boots");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}