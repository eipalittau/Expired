using Exp.Data.Player;

namespace Exp.DefaultMod.Player.Slot {
    internal sealed class WristLeft : SlotDataBase, ISlotData {
        #region Konstruktor
        internal WristLeft()
            : base(nameof(WristLeft), 700, false) {
            Name.Set(Util.LanguageEnum.Deutsch, "Handgelenk links");
            Name.Set(Util.LanguageEnum.English, "Wrist left");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Für Schmuck");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}