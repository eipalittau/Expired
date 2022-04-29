using Exp.Data.Item;

namespace Exp.DefaultMod.Item.ItemType {
    internal sealed class Consumable : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal Consumable()
            : base(nameof(Consumable), 1800, null, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Bag))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Konsumierbar");
            Name.Set(Util.LanguageEnum.English, "Consumable");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}