using Exp.Data.Item.ItemType;

namespace Exp.DefaultMod.Item.ItemType {
    public sealed class OneHandedWeapon : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        private OneHandedWeapon()
            : base(nameof(OneHandedWeapon), 300, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Mainhand)), 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Offhand))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Einhandwaffe");
            Name.Set(Util.LanguageEnum.English, "One-handed weapon");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new OneHandedWeapon());
        }
        #endregion
    }
}