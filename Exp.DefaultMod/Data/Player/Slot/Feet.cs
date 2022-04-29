using Exp.Data.Player;

namespace Exp.DefaultMod.Player.Slot {
    internal sealed class Feet : SlotDataBase, ISlotData {
        #region Konstruktor
        internal Feet()
            : base(nameof(Feet), 200, false) {
            Name.Set(Util.LanguageEnum.Deutsch, "Füsse");
            Name.Set(Util.LanguageEnum.English, "Feet");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Für Schuhe");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}