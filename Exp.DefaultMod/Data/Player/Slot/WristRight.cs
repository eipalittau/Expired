using Exp.Data.Player.Slot;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Player.Slot
{
    public sealed class WristRight : SlotDataBase, ISlotData {
        #region Konstruktor
        private WristRight()
            : base(nameof(WristRight), 800, false) {
            Name.Set(LanguageEnum.Deutsch, "Handgelenk rechts");
            Name.Set(LanguageEnum.English, "Wrist right");
            LoreDescription.Set(LanguageEnum.Deutsch, "Für Schmuck");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new WristRight());
        }
        #endregion
    }
}