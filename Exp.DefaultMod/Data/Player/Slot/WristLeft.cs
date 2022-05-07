namespace Exp.DefaultMod.Player.Slot {
    public sealed class WristLeft : Exp.Data.Player.SlotDataBase, Exp.Data.Player.ISlotData {
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