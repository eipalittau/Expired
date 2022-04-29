using Exp.Data.Item;

namespace Exp.DefaultMod.Item.ItemType {
    internal sealed class Shield : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal Shield()
            : base(nameof(Shield), 1000, null, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Offhand))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schild");
            Name.Set(Util.LanguageEnum.English, "Shield");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}