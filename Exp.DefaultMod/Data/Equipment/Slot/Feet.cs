using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.Slot {
    internal sealed class Feet : SlotDataBase, ISlotData {
        #region Konstruktor
        internal Feet()
            : base(nameof(Feet), 200, false) {
            Name.Set(Util.LanguageEnum.Deutsch, "Füsse");
            Name.Set(Util.LanguageEnum.English, "Feet");
            Description.Set(Util.LanguageEnum.Deutsch, "Für Schuhe");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}