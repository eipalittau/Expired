using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment {
    internal sealed class Bag : SlotBase, ISlotData {
        #region Konstruktor
        internal Bag()
            : base(nameof(Bag), 1200) {
            Name.Set(Util.LanguageEnum.Deutsch, "Tasche");
            Name.Set(Util.LanguageEnum.English, "Bag");
            Description.Set(Util.LanguageEnum.Deutsch, "Für alles andere");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}