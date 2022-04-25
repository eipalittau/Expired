using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.Slot {
    internal sealed class Neck : SlotDataBase, ISlotData {
        #region Konstruktor
        internal Neck()
            : base(nameof(Neck), 900) {
            Name.Set(Util.LanguageEnum.Deutsch, "Hals");
            Name.Set(Util.LanguageEnum.English, "Neck");
            Description.Set(Util.LanguageEnum.Deutsch, "Für Schmuck");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}