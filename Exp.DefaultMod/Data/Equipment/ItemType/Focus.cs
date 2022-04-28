using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.ItemType {
    internal sealed class Focus : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal Focus()
            : base(nameof(Focus), 1100, null, Api.Equipment.Slot.Singleton.Get("Offhand")) {
            Name.Set(Util.LanguageEnum.Deutsch, "Heiliges Symbol");
            Name.Set(Util.LanguageEnum.English, "Focus");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}