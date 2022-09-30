using Exp.Data.Player.Slot;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Player.Slot
{
    public sealed class Feet : SlotDataBase, ISlotData {
        #region Konstruktor
        private Feet()
            : base(nameof(Feet), 200, false) {
            Name.Set(LanguageEnum.Deutsch, "Füsse");
            Name.Set(LanguageEnum.English, "Feet");
            LoreDescription.Set(LanguageEnum.Deutsch, "Für Schuhe");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Feet());
        }
        #endregion
    }
}