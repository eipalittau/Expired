using Exp.Data.Player;

namespace Exp.DefaultMod.Player.Slot {
    internal sealed class RingFingerLeft : SlotDataBase, ISlotData {
        #region Konstruktor
        internal RingFingerLeft()
            : base(nameof(RingFingerLeft), 500) {
            Name.Set(Util.LanguageEnum.Deutsch, "Ringfinger links");
            Name.Set(Util.LanguageEnum.English, "Left ring finger");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Für Schmuck");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}