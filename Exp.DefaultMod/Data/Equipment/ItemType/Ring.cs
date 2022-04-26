using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.ItemType {
    internal sealed class Ring : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal Ring()
            : base(nameof(Ring), 1300, null, Api.Equipment.Slot.Singleton.Get("RingFingerLeft"), Api.Equipment.Slot.Singleton.Get("RingFingerRight")) {
            Name.Set(Util.LanguageEnum.Deutsch, "Ring");
            Name.Set(Util.LanguageEnum.English, "Ring");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}