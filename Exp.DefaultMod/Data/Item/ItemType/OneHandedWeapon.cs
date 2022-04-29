using Exp.Data.Item;

namespace Exp.DefaultMod.Item.ItemType {
    internal sealed class OneHandedWeapon : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal OneHandedWeapon()
            : base(nameof(OneHandedWeapon), 300, null, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Mainhand)), 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Offhand))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Einhandwaffe");
            Name.Set(Util.LanguageEnum.English, "One-handed weapon");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}