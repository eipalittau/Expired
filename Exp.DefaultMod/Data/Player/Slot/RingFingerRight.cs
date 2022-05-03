namespace Exp.DefaultMod.Player.Slot {
    internal sealed class RingFingerRight : Exp.Data.Player.SlotDataBase, Exp.Data.Player.ISlotData {
        #region Konstruktor
        internal RingFingerRight()
            : base(nameof(RingFingerRight), 600, true) {
            Name.Set(Util.LanguageEnum.Deutsch, "Ringfinger rechts");
            Name.Set(Util.LanguageEnum.English, "Right ring finger");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Für Schmuck");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}