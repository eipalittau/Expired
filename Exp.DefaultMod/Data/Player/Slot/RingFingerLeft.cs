namespace Exp.DefaultMod.Player.Slot {
    internal sealed class RingFingerLeft : Exp.Data.Player.SlotDataBase, Exp.Data.Player.ISlotData {
        #region Konstruktor
        internal RingFingerLeft()
            : base(nameof(RingFingerLeft), 500, true) {
            Name.Set(Util.LanguageEnum.Deutsch, "Ringfinger links");
            Name.Set(Util.LanguageEnum.English, "Left ring finger");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Für Schmuck");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}