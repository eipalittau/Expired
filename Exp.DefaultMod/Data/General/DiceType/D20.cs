namespace Exp.DefaultMod.General.DiceType {
    public sealed class D20 : Exp.Data.General.DiceTypeBase, Exp.Data.General.IDiceTypeData {
        #region Konstruktor
        private D20()
            : base(nameof(D20), 600, 20) {
            Name.Set(Util.LanguageEnum.Deutsch, "W20");
            Name.Set(Util.LanguageEnum.English, "D20");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new D20());
        }
        #endregion
    }
}