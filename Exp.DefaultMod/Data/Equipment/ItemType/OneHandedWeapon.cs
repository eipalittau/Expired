using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.ItemType {
    internal sealed class OneHandedWeapon : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal OneHandedWeapon()
            : base(nameof(OneHandedWeapon), 300, null, Api.Equipment.Slot.Singleton.Get("Mainhand"), Api.Equipment.Slot.Singleton.Get("Offhand")) {
            Name.Set(Util.LanguageEnum.Deutsch, "Einhandwaffe");
            Name.Set(Util.LanguageEnum.English, "One-handed weapon");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}