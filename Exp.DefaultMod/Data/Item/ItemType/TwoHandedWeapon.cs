namespace Exp.DefaultMod.Item.ItemType {
    internal sealed class TwoHandedWeapon : Exp.Data.Item.ItemTypeDataBase, Exp.Data.Item.IItemTypeData {
        #region Konstruktor
        internal TwoHandedWeapon()
            : base(nameof(TwoHandedWeapon), 400, null, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Mainhand)), 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Offhand))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Zweihandwaffe");
            Name.Set(Util.LanguageEnum.English, "Two-handed weapon");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}