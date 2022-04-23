using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment {
    internal sealed class RingFingerLeft : SlotBase, ISlotData {
        #region Konstruktor
        internal RingFingerLeft()
            : base(nameof(RingFingerLeft), 500) {
            Name.Set(Util.LanguageEnum.Deutsch, "Ringfinger links");
            Name.Set(Util.LanguageEnum.English, "Left ring finger");
            Description.Set(Util.LanguageEnum.Deutsch, "Für Schmuck");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}