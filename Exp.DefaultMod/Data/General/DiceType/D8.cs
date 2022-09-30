using Exp.Data.General.DiceType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.General.DiceType
{
    public sealed class D8 : DiceTypeBase, IDiceTypeData {
        #region Konstruktor
        private D8()
            : base(nameof(D8), 300, 8) {
            Name.Set(LanguageEnum.Deutsch, "W8");
            Name.Set(LanguageEnum.English, "D8");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }

        #region Methoden
        public static void Add() {
            AddInstance(new D8());
        }
        #endregion
        #endregion
    }
}