using Exp.Data.General.DiceType;

namespace Exp.DefaultMod.General.DiceType {
    public sealed class D6 : DiceTypeBase, IDiceTypeData {
        #region Konstruktor
        private D6()
            : base(nameof(D6), 200, 6) {
            Name.Set(Util.LanguageEnum.Deutsch, "W6");
            Name.Set(Util.LanguageEnum.English, "D6");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new D6());
        }
        #endregion
    }
}