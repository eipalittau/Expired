using Exp.Data.General.DiceType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.General.DiceType
{
    public sealed class D12 : DiceTypeBase, IDiceTypeData {
        #region Konstruktor
        private D12()
            : base(nameof(D12), 500, 12) {
            Name.Set(LanguageEnum.Deutsch, "W12");
            Name.Set(LanguageEnum.English, "D12");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new D12());
        }
        #endregion
    }
}