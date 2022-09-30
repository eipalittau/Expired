using Exp.Data.General.DiceType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.General.DiceType
{
    public sealed class D10 : DiceTypeBase, IDiceTypeData {
        #region Konstruktor
        private D10()
            : base(nameof(D10), 400, 10) {
            Name.Set(LanguageEnum.Deutsch, "W10");
            Name.Set(LanguageEnum.English, "D10");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new D10());
        }
        #endregion
    }
}