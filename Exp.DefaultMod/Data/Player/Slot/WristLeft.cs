using Exp.Data.Player.Slot;

namespace Exp.DefaultMod.Player.Slot {
    public sealed class WristLeft : SlotDataBase, ISlotData {
        #region Konstruktor
        private WristLeft()
            : base(nameof(WristLeft), 700, false) {
            Name.Set(Util.LanguageEnum.Deutsch, "Handgelenk links");
            Name.Set(Util.LanguageEnum.English, "Wrist left");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Für Schmuck");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new WristLeft());
        }
        #endregion
    }
}