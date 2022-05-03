namespace Exp.DefaultMod.Player.Slot {
    internal sealed class Offhand : Exp.Data.Player.SlotDataBase, Exp.Data.Player.ISlotData {
        #region Konstruktor
        internal Offhand()
            : base(nameof(Offhand), 400, true) {
            Name.Set(Util.LanguageEnum.Deutsch, "Nebenhand");
            Name.Set(Util.LanguageEnum.English, "Offhand");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Die schwache Hand. Alles klar?");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}