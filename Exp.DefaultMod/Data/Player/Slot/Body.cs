using Exp.Data.Player.Slot;

namespace Exp.DefaultMod.Player.Slot {
    public sealed class Body : SlotDataBase, ISlotData {
        #region Konstruktor
        private Body()
            : base(nameof(Body), 100, true) {
            Name.Set(Util.LanguageEnum.Deutsch, "Körper");
            Name.Set(Util.LanguageEnum.English, "Body");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Schützt vor Angriffen");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Body());
        }
        #endregion
    }
}