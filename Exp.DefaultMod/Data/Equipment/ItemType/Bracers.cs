using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.ItemType {
    internal sealed class Bracers : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal Bracers()
            : base(nameof(Bracers), 1700, null, Api.Equipment.Slot.Singleton.Get("WristLeft"), Api.Equipment.Slot.Singleton.Get("WristRight")) {
            Name.Set(Util.LanguageEnum.Deutsch, "Armschutz");
            Name.Set(Util.LanguageEnum.English, "Bracers");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}