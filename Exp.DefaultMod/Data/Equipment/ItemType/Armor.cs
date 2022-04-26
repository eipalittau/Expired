using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.ItemType {
    internal sealed class Armor : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal Armor()
            : base(nameof(Armor), 100, null, Api.Equipment.Slot.Singleton.Get("Body")) {
            Name.Set(Util.LanguageEnum.Deutsch, "Rüstung");
            Name.Set(Util.LanguageEnum.English, "Armor");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}