using Exp.Data.Player.Slot;

namespace Exp.DefaultMod.Player.Slot {
    public sealed class RingFingerLeft : SlotDataBase, ISlotData {
        #region Konstruktor
        private RingFingerLeft()
            : base(nameof(RingFingerLeft), 500, true) {
            Name.Set(Util.LanguageEnum.Deutsch, "Ringfinger links");
            Name.Set(Util.LanguageEnum.English, "Left ring finger");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Für Schmuck");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new RingFingerLeft());
        }
        #endregion
    }
}