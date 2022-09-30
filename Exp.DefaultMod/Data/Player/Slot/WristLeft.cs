using Exp.Data.Player.Slot;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Player.Slot
{
    public sealed class WristLeft : SlotDataBase, ISlotData {
        #region Konstruktor
        private WristLeft()
            : base(nameof(WristLeft), 700, false) {
            Name.Set(LanguageEnum.Deutsch, "Handgelenk links");
            Name.Set(LanguageEnum.English, "Wrist left");
            LoreDescription.Set(LanguageEnum.Deutsch, "Für Schmuck");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new WristLeft());
        }
        #endregion
    }
}