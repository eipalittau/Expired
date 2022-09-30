using Exp.Data.Item.ItemType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Item.ItemType
{
    public sealed class OneHandedWeapon : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        private OneHandedWeapon()
            : base(nameof(OneHandedWeapon), 300, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Mainhand)), 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Offhand))) {
            Name.Set(LanguageEnum.Deutsch, "Einhandwaffe");
            Name.Set(LanguageEnum.English, "One-handed weapon");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new OneHandedWeapon());
        }
        #endregion
    }
}