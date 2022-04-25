using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.Slot {
    internal sealed class Mainhand : SlotDataBase, ISlotData {
        #region Konstruktor
        internal Mainhand()
            : base(nameof(Mainhand), 300) {
            Name.Set(Util.LanguageEnum.Deutsch, "Haupthand");
            Name.Set(Util.LanguageEnum.English, "Mainhand");
            Description.Set(Util.LanguageEnum.Deutsch, "Die starke Hand. Mit dieser Hand schwingst du deine epische Waffe.");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}