namespace Exp.DefaultMod.Player.Slot {
    public sealed class Offhand : Exp.Data.Player.SlotDataBase, Exp.Data.Player.ISlotData {
        #region Konstruktor
        private Offhand()
            : base(nameof(Offhand), 400, true) {
            Name.Set(Util.LanguageEnum.Deutsch, "Nebenhand");
            Name.Set(Util.LanguageEnum.English, "Offhand");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Die schwache Hand. Alles klar?");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Offhand());
        }
        #endregion
    }
}