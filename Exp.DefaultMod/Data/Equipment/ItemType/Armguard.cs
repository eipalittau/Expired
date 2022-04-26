using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.ItemType {
    internal sealed class Armguard : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal Armguard()
            : base(nameof(Armguard), 1700, null, Api.Equipment.Slot.Singleton.Get("WristLeft"), Api.Equipment.Slot.Singleton.Get("WristRight")) {
            Name.Set(Util.LanguageEnum.Deutsch, "Armschutz");
            Name.Set(Util.LanguageEnum.English, "Armguard");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}