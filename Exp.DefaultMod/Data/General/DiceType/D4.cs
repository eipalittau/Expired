using Exp.Data.General.DiceType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.General.DiceType
{
    public sealed class D4 : DiceTypeBase, IDiceTypeData {
        #region Konstruktor
        private D4()
            : base(nameof(D4), 100, 4) {
            Name.Set(LanguageEnum.Deutsch, "W4");
            Name.Set(LanguageEnum.English, "D4");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new D4());
        }
        #endregion
    }
}
