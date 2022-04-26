using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.Slot {
    internal sealed class Head : SlotDataBase, ISlotData {
        #region Konstruktor
        internal Head()
            : base(nameof(Head), 1100) {
            Name.Set(Util.LanguageEnum.Deutsch, "Kopf");
            Name.Set(Util.LanguageEnum.English, "Head");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Für Schmuck");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}