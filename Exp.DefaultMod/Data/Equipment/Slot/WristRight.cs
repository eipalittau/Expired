using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.Slot {
    internal sealed class WristRight : SlotDataBase, ISlotData {
        #region Konstruktor
        internal WristRight()
            : base(nameof(WristRight), 800, false) {
            Name.Set(Util.LanguageEnum.Deutsch, "Handgelenk rechts");
            Name.Set(Util.LanguageEnum.English, "Wrist right");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Für Schmuck");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}