using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.ItemType {
    internal sealed class Dagger : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal Dagger()
            : base(nameof(Dagger), 900, null, Api.Equipment.Slot.Singleton.Get("Offhand")) {
            Name.Set(Util.LanguageEnum.Deutsch, "Dolch");
            Name.Set(Util.LanguageEnum.English, "Dagger");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}