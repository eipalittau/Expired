using Exp.Data.Player.Slot;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Player.Slot
{
    public sealed class Bag : SlotDataBase, ISlotData {
        #region Konstruktor
        private Bag()
            : base(nameof(Bag), 1200, true) {
            Name.Set(LanguageEnum.Deutsch, "Tasche");
            Name.Set(LanguageEnum.English, "Bag");
            LoreDescription.Set(LanguageEnum.Deutsch, "Für alles andere");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Bag());
        }
        #endregion
    }
}