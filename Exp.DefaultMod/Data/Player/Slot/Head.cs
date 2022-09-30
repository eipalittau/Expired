using Exp.Data.Player.Slot;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Player.Slot
{
    public sealed class Head : SlotDataBase, ISlotData {
        #region Konstruktor
        private Head()
            : base(nameof(Head), 1100, true) {
            Name.Set(LanguageEnum.Deutsch, "Kopf");
            Name.Set(LanguageEnum.English, "Head");
            LoreDescription.Set(LanguageEnum.Deutsch, "Für Schmuck");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Head());
        }
        #endregion
    }
}