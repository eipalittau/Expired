using Exp.Data.General.DiceType;

namespace Exp.DefaultMod.General.DiceType {
    public sealed class D100 : DiceTypeBase, IDiceTypeData {
        #region Konstruktor
        private D100()
            : base(nameof(D100), 700, 100) {
            Name.Set(Util.LanguageEnum.Deutsch, "W100");
            Name.Set(Util.LanguageEnum.English, "D100");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new D100());
        }
        #endregion
    }
}