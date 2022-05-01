using Exp.Data.Player;

namespace Exp.DefaultMod.Player.Slot {
    internal sealed class Skeleton : SlotDataBase, ISlotData {
        #region Konstruktor
        internal Skeleton()
            : base(nameof(Skeleton), 100) {
            Name.Set(Util.LanguageEnum.Deutsch, "Skelett");
            Name.Set(Util.LanguageEnum.English, "Skeleton");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}