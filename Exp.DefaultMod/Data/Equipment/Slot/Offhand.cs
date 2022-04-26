using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.Slot {
    internal sealed class Offhand : SlotDataBase, ISlotData {
        #region Konstruktor
        internal Offhand()
            : base(nameof(Offhand), 400) {
            Name.Set(Util.LanguageEnum.Deutsch, "Nebenhand");
            Name.Set(Util.LanguageEnum.English, "Offhand");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Die schwache Hand. Alles klar?");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}