using Exp.Data.General.DiceType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.General.DiceType
{
    public sealed class D20 : DiceTypeBase, IDiceTypeData {
        #region Konstruktor
        private D20()
            : base(nameof(D20), 600, 20) {
            Name.Set(LanguageEnum.Deutsch, "W20");
            Name.Set(LanguageEnum.English, "D20");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new D20());
        }
        #endregion
    }
}