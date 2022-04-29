using Exp.Data.Item;

namespace Exp.DefaultMod.Item.ItemType {
    internal sealed class Focus : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal Focus()
            : base(nameof(Focus), 1100, null, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Offhand))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Heiliges Symbol");
            Name.Set(Util.LanguageEnum.English, "Focus");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}