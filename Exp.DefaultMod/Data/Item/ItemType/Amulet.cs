using Exp.Data.Item;

namespace Exp.DefaultMod.Item.ItemType {
    internal sealed class Amulet : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal Amulet()
            : base(nameof(Amulet), 1400, null, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Neck))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Amulett");
            Name.Set(Util.LanguageEnum.English, "Amulet");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}