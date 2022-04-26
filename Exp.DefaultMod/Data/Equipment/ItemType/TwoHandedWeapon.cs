using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.ItemType {
    internal sealed class TwoHandedWeapon : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal TwoHandedWeapon()
            : base(nameof(TwoHandedWeapon), 400, null, Api.Equipment.Slot.Singleton.Get("Mainhand"), Api.Equipment.Slot.Singleton.Get("Offhand")) {
            Name.Set(Util.LanguageEnum.Deutsch, "Zweihandwaffe");
            Name.Set(Util.LanguageEnum.English, "Two-handed weapon");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}