using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment {
    internal sealed class Armor : SlotBase, ISlotData {
        #region Konstruktor
        internal Armor()
            : base(nameof(Armor), 100) {
            Name.Set(Util.LanguageEnum.Deutsch, "Rüstung");
            Name.Set(Util.LanguageEnum.English, "Armor");
            Description.Set(Util.LanguageEnum.Deutsch, "Schützt vor Angriffen");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}