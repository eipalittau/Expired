using Exp.Data.General.DiceType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.General.DiceType
{
    public sealed class D6 : DiceTypeBase, IDiceTypeData {
        #region Konstruktor
        private D6()
            : base(nameof(D6), 200, 6) {
            Name.Set(LanguageEnum.Deutsch, "W6");
            Name.Set(LanguageEnum.English, "D6");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new D6());
        }
        #endregion
    }
}