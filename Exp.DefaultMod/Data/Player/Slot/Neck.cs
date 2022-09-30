using Exp.Data.Player.Slot;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Player.Slot
{
    public sealed class Neck : SlotDataBase, ISlotData { 
        #region Konstruktor
        private Neck()
            : base(nameof(Neck), 900, true) {
            Name.Set(LanguageEnum.Deutsch, "Hals");
            Name.Set(LanguageEnum.English, "Neck");
            LoreDescription.Set(LanguageEnum.Deutsch, "Für Schmuck");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Neck());
        }
        #endregion
    }
}