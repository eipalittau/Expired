namespace Exp.DefaultMod.Player.Slot {
    public sealed class Bag : Exp.Data.Player.SlotDataBase, Exp.Data.Player.ISlotData {
        #region Konstruktor
        private Bag()
            : base(nameof(Bag), 1200, true) {
            Name.Set(Util.LanguageEnum.Deutsch, "Tasche");
            Name.Set(Util.LanguageEnum.English, "Bag");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Für alles andere");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Bag());
        }
        #endregion
    }
}