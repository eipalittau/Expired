using Exp.Data.Player.Slot;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Player.Slot
{
    public sealed class RingFingerRight : SlotDataBase, ISlotData {
        #region Konstruktor
        private RingFingerRight()
            : base(nameof(RingFingerRight), 600, true) {
            Name.Set(LanguageEnum.Deutsch, "Ringfinger rechts");
            Name.Set(LanguageEnum.English, "Right ring finger");
            LoreDescription.Set(LanguageEnum.Deutsch, "Für Schmuck");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new RingFingerRight());
        }
        #endregion
    }
}