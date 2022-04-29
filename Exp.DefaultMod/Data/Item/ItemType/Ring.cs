using Exp.Data.Item;

namespace Exp.DefaultMod.Item.ItemType {
    internal sealed class Ring : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal Ring()
            : base(nameof(Ring), 1300, null, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.RingFingerLeft)), 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.RingFingerRight))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Ring");
            Name.Set(Util.LanguageEnum.English, "Ring");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}