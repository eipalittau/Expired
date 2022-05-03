namespace Exp.DefaultMod.Player.Slot {
    internal sealed class Neck : Exp.Data.Player.SlotDataBase, Exp.Data.Player.ISlotData { {
        #region Konstruktor
        internal Neck()
            : base(nameof(Neck), 900, true) {
            Name.Set(Util.LanguageEnum.Deutsch, "Hals");
            Name.Set(Util.LanguageEnum.English, "Neck");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Für Schmuck");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}