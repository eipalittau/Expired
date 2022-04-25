using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.ItemType {
    internal sealed class Arrows : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal Arrows()
            : base(nameof(Arrows), 700, Api.Equipment.ItemType.Singleton.Get("Bow"), Api.Equipment.Slot.Singleton.Get("Mainhand"), Api.Equipment.Slot.Singleton.Get("Offhand")) {
            Name.Set(Util.LanguageEnum.Deutsch, "Pfeile");
            Name.Set(Util.LanguageEnum.English, "Arrows");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}