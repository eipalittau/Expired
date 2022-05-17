using Exp.Data.Player.Slot;

namespace Exp.DefaultMod.Player.Slot {
    public sealed class Neck : SlotDataBase, ISlotData { 
        #region Konstruktor
        private Neck()
            : base(nameof(Neck), 900, true) {
            Name.Set(Util.LanguageEnum.Deutsch, "Hals");
            Name.Set(Util.LanguageEnum.English, "Neck");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Für Schmuck");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Neck());
        }
        #endregion
    }
}