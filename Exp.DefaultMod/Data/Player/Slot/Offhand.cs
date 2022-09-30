using Exp.Data.Player.Slot;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Player.Slot
{
    public sealed class Offhand : SlotDataBase, ISlotData {
        #region Konstruktor
        private Offhand()
            : base(nameof(Offhand), 400, true) {
            Name.Set(LanguageEnum.Deutsch, "Nebenhand");
            Name.Set(LanguageEnum.English, "Offhand");
            LoreDescription.Set(LanguageEnum.Deutsch, "Die schwache Hand. Alles klar?");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Offhand());
        }
        #endregion
    }
}