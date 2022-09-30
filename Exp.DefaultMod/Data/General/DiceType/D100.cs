using Exp.Data.General.DiceType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.General.DiceType
{
    public sealed class D100 : DiceTypeBase, IDiceTypeData {
        #region Konstruktor
        private D100()
            : base(nameof(D100), 700, 100) {
            Name.Set(LanguageEnum.Deutsch, "W100");
            Name.Set(LanguageEnum.English, "D100");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new D100());
        }
        #endregion
    }
}