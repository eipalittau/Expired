namespace Exp.DefaultMod.Player.Slot {
    public sealed class Head : Exp.Data.Player.SlotDataBase, Exp.Data.Player.ISlotData {
        #region Konstruktor
        private Head()
            : base(nameof(Head), 1100, true) {
            Name.Set(Util.LanguageEnum.Deutsch, "Kopf");
            Name.Set(Util.LanguageEnum.English, "Head");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Für Schmuck");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Head());
        }
        #endregion
    }
}