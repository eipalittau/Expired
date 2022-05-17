using Exp.Data.Player.Slot;

namespace Exp.DefaultMod.Player.Slot {
    public sealed class RingFingerRight : SlotDataBase, ISlotData {
        #region Konstruktor
        private RingFingerRight()
            : base(nameof(RingFingerRight), 600, true) {
            Name.Set(Util.LanguageEnum.Deutsch, "Ringfinger rechts");
            Name.Set(Util.LanguageEnum.English, "Right ring finger");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Für Schmuck");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new RingFingerRight());
        }
        #endregion
    }
}