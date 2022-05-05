namespace Exp.DefaultMod.General.DiceType {
    public sealed class D10 : Exp.Data.General.DiceTypeBase, Exp.Data.General.IDiceTypeData {
        #region Konstruktor
        private D10()
            : base(nameof(D10), 400, 10) {
            Name.Set(Util.LanguageEnum.Deutsch, "W10");
            Name.Set(Util.LanguageEnum.English, "D10");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new D10());
        }
        #endregion
    }
}