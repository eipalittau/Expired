using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.ItemType {
    internal sealed class HolySymbol : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal HolySymbol()
            : base(nameof(HolySymbol), 1100, null, Api.Equipment.Slot.Singleton.Get("Offhand")) {
            Name.Set(Util.LanguageEnum.Deutsch, "Heiliges Symbol");
            Name.Set(Util.LanguageEnum.English, "Holy symbol");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}