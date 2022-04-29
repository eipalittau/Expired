using Exp.Data.Player;

namespace Exp.DefaultMod.Player.Slot {
    internal sealed class Body : SlotDataBase, ISlotData {
        #region Konstruktor
        internal Body()
            : base(nameof(Body), 100) {
            Name.Set(Util.LanguageEnum.Deutsch, "Körper");
            Name.Set(Util.LanguageEnum.English, "Body");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Schützt vor Angriffen");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}