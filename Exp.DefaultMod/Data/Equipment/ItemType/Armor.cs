using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment {
    internal sealed class Armor : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal Armor()
            : base(nameof(Armor), 100, null, Api.Equipment.Slot.Singleton.Get("Body")) {
            Name.Set(Util.LanguageEnum.Deutsch, "Rüstung");
            Name.Set(Util.LanguageEnum.English, "Armor");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}