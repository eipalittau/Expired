using Exp.Data.Item;

namespace Exp.DefaultMod.Item.ItemType {
    internal sealed class Cape : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal Cape()
            : base(nameof(Cape), 1500, null, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Shoulders))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Umhang");
            Name.Set(Util.LanguageEnum.English, "Cape");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}