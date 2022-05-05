namespace Exp.DefaultMod.General.DiceType {
    public sealed class D12 : Exp.Data.General.DiceTypeBase, Exp.Data.General.IDiceTypeData {
        #region Konstruktor
        private D12()
            : base(nameof(D12), 500, 12) {
            Name.Set(Util.LanguageEnum.Deutsch, "W12");
            Name.Set(Util.LanguageEnum.English, "D12");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new D12());
        }
        #endregion
    }
}