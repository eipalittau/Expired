using Exp.Data.Item;

namespace Exp.DefaultMod.Item.ItemType {
    internal sealed class Grimoire : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal Grimoire()
            : base(nameof(Grimoire), 1200, null, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Offhand))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Zauberbuch");
            Name.Set(Util.LanguageEnum.English, "Grimoire");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}