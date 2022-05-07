namespace Exp.DefaultMod.Player.Slot {
    public sealed class Body : Exp.Data.Player.SlotDataBase, Exp.Data.Player.ISlotData {
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