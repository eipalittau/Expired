using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.Slot {
    internal sealed class RingFingerRight : SlotDataBase, ISlotData {
        #region Konstruktor
        internal RingFingerRight()
            : base(nameof(RingFingerRight), 600) {
            Name.Set(Util.LanguageEnum.Deutsch, "Ringfinger rechts");
            Name.Set(Util.LanguageEnum.English, "Right ring finger");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Für Schmuck");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}