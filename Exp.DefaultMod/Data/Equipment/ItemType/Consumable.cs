using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.ItemType {
    internal sealed class Consumable : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal Consumable()
            : base(nameof(Consumable), 1800, null, Api.Equipment.Slot.Singleton.Get("Bag")) {
            Name.Set(Util.LanguageEnum.Deutsch, "Konsumierbar");
            Name.Set(Util.LanguageEnum.English, "Consumable");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}