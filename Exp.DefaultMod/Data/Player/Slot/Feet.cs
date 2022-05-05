namespace Exp.DefaultMod.Player.Slot {
    public sealed class Feet : Exp.Data.Player.SlotDataBase, Exp.Data.Player.ISlotData {
        #region Konstruktor
        private Feet()
            : base(nameof(Feet), 200, false) {
            Name.Set(Util.LanguageEnum.Deutsch, "Füsse");
            Name.Set(Util.LanguageEnum.English, "Feet");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Für Schuhe");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Feet());
        }
        #endregion
    }
}