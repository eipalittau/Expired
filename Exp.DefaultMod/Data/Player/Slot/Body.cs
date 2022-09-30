using Exp.Data.Player.Slot;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Player.Slot
{
    public sealed class Body : SlotDataBase, ISlotData {
        #region Konstruktor
        private Body()
            : base(nameof(Body), 100, true) {
            Name.Set(LanguageEnum.Deutsch, "Körper");
            Name.Set(LanguageEnum.English, "Body");
            LoreDescription.Set(LanguageEnum.Deutsch, "Schützt vor Angriffen");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Body());
        }
        #endregion
    }
}