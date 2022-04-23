using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment {
    internal sealed class Head : SlotDataBase, ISlotData {
        #region Konstruktor
        internal Head()
            : base(nameof(Head), 1100) {
            Name.Set(Util.LanguageEnum.Deutsch, "Kopf");
            Name.Set(Util.LanguageEnum.English, "Head");
            Description.Set(Util.LanguageEnum.Deutsch, "Für Schmuck");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}