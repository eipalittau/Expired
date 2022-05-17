using Exp.Data.General.DiceType;

namespace Exp.DefaultMod.General.DiceType {
    public sealed class D4 : DiceTypeBase, IDiceTypeData {
        #region Konstruktor
        private D4()
            : base(nameof(D4), 100, 4) {
            Name.Set(Util.LanguageEnum.Deutsch, "W4");
            Name.Set(Util.LanguageEnum.English, "D4");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new D4());
        }
        #endregion
    }
}
