using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment {
    internal sealed class Shoulders : SlotBase, ISlotData {
        #region Konstruktor
        internal Shoulders()
            : base(nameof(Shoulders), 1000) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schultern");
            Name.Set(Util.LanguageEnum.English, "Shoulders");
            Description.Set(Util.LanguageEnum.Deutsch, "Für ein Cape wie es Superman trägt.");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}