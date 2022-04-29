using Exp.Data.Item;

namespace Exp.DefaultMod.Item.ItemType {
    internal sealed class Boots : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal Boots()
            : base(nameof(Boots), 200, null, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Feet))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Stiefel");
            Name.Set(Util.LanguageEnum.English, "Boots");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}