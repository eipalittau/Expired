using Exp.Data.Item.ItemType;

namespace Exp.DefaultMod.Item.ItemType {
    public sealed class TwoHandedWeapon : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        private TwoHandedWeapon()
            : base(nameof(TwoHandedWeapon), 400, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Mainhand)), 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Offhand))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Zweihandwaffe");
            Name.Set(Util.LanguageEnum.English, "Two-handed weapon");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new TwoHandedWeapon());
        }
        #endregion
    }
}