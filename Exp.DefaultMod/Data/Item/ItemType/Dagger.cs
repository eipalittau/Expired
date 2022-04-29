using Exp.Data.Item;

namespace Exp.DefaultMod.Item.ItemType {
    internal sealed class Dagger : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal Dagger()
            : base(nameof(Dagger), 900, null, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Offhand))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Dolch");
            Name.Set(Util.LanguageEnum.English, "Dagger");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}