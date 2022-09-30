using Exp.Data.Player.Slot;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Player.Slot
{
    public sealed class Shoulders : SlotDataBase, ISlotData {
        #region Konstruktor
        private Shoulders()
            : base(nameof(Shoulders), 1000, true) {
            Name.Set(LanguageEnum.Deutsch, "Schultern");
            Name.Set(LanguageEnum.English, "Shoulders");
            LoreDescription.Set(LanguageEnum.Deutsch, "Für ein Cape wie es Superman trägt.");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Shoulders());
        }
        #endregion
    }
}