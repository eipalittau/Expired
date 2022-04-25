using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.ItemType {
    internal sealed class Bolt : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal Bolt()
            : base(nameof(Bolt), 800, Api.Equipment.ItemType.Singleton.Get("Crossbow"), Api.Equipment.Slot.Singleton.Get("Mainhand"), Api.Equipment.Slot.Singleton.Get("Offhand")) {
            Name.Set(Util.LanguageEnum.Deutsch, "Bolzen");
            Name.Set(Util.LanguageEnum.English, "Bolt");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}