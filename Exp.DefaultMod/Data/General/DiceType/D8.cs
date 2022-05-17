using Exp.Data.General.DiceType;

namespace Exp.DefaultMod.General.DiceType {
    public sealed class D8 : DiceTypeBase, IDiceTypeData {
        #region Konstruktor
        private D8()
            : base(nameof(D8), 300, 8) {
            Name.Set(Util.LanguageEnum.Deutsch, "W8");
            Name.Set(Util.LanguageEnum.English, "D8");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }

        #region Methoden
        public static void Add() {
            AddInstance(new D8());
        }
        #endregion
        #endregion
    }
}