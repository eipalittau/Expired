namespace Exp.DefaultMod.Player.Slot {
    internal sealed class Shoulders : Exp.Data.Player.SlotDataBase, Exp.Data.Player.ISlotData {
        #region Konstruktor
        internal Shoulders()
            : base(nameof(Shoulders), 1000, true) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schultern");
            Name.Set(Util.LanguageEnum.English, "Shoulders");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Für ein Cape wie es Superman trägt.");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}