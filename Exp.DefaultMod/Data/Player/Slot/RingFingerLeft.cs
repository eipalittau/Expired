using Exp.Data.Player.Slot;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Player.Slot
{
    public sealed class RingFingerLeft : SlotDataBase, ISlotData {
        #region Konstruktor
        private RingFingerLeft()
            : base(nameof(RingFingerLeft), 500, true) {
            Name.Set(LanguageEnum.Deutsch, "Ringfinger links");
            Name.Set(LanguageEnum.English, "Left ring finger");
            LoreDescription.Set(LanguageEnum.Deutsch, "Für Schmuck");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new RingFingerLeft());
        }
        #endregion
    }
}