namespace Exp.DefaultMod.Player.Slot {
    public sealed class WristRight : Exp.Data.Player.SlotDataBase, Exp.Data.Player.ISlotData {
        #region Konstruktor
        private WristRight()
            : base(nameof(WristRight), 800, false) {
            Name.Set(Util.LanguageEnum.Deutsch, "Handgelenk rechts");
            Name.Set(Util.LanguageEnum.English, "Wrist right");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Für Schmuck");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new WristRight());
        }
        #endregion
    }
}