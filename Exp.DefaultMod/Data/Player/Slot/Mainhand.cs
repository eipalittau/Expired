namespace Exp.DefaultMod.Player.Slot {
    public sealed class Mainhand : Exp.Data.Player.SlotDataBase, Exp.Data.Player.ISlotData {
        #region Konstruktor
        private Mainhand()
            : base(nameof(Mainhand), 300, true) {
            Name.Set(Util.LanguageEnum.Deutsch, "Haupthand");
            Name.Set(Util.LanguageEnum.English, "Mainhand");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Die starke Hand. Mit dieser Hand schwingst du deine epische Waffe.");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Mainhand());
        }
        #endregion
    }
}