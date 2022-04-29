using Exp.Data.Player;

namespace Exp.DefaultMod.Player.Slot {
    internal sealed class Bag : SlotDataBase, ISlotData {
        #region Konstruktor
        internal Bag()
            : base(nameof(Bag), 1200) {
            Name.Set(Util.LanguageEnum.Deutsch, "Tasche");
            Name.Set(Util.LanguageEnum.English, "Bag");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Für alles andere");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}