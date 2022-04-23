using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment {
    internal sealed class Body : SlotDataBase, ISlotData {
        #region Konstruktor
        internal Body()
            : base(nameof(Body), 100) {
            Name.Set(Util.LanguageEnum.Deutsch, "Körper");
            Name.Set(Util.LanguageEnum.English, "Body");
            Description.Set(Util.LanguageEnum.Deutsch, "Schützt vor Angriffen");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}