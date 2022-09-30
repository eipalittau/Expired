using Exp.Data.Item.ItemType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Item.ItemType
{
    public sealed class TwoHandedWeapon : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        private TwoHandedWeapon()
            : base(nameof(TwoHandedWeapon), 400, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Mainhand)), 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Offhand))) {
            Name.Set(LanguageEnum.Deutsch, "Zweihandwaffe");
            Name.Set(LanguageEnum.English, "Two-handed weapon");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new TwoHandedWeapon());
        }
        #endregion
    }
}