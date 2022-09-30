using Exp.Data.Player.Slot;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Player.Slot
{
    public sealed class Mainhand : SlotDataBase, ISlotData {
        #region Konstruktor
        private Mainhand()
            : base(nameof(Mainhand), 300, true) {
            Name.Set(LanguageEnum.Deutsch, "Haupthand");
            Name.Set(LanguageEnum.English, "Mainhand");
            LoreDescription.Set(LanguageEnum.Deutsch, "Die starke Hand. Mit dieser Hand schwingst du deine epische Waffe.");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Mainhand());
        }
        #endregion
    }
}