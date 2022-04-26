using Exp.Data.General;

namespace Exp.DefaultMod.General {
    internal sealed class D8 : DiceTypeBase, IDiceTypeData {
        #region Konstruktor
        internal D8()
            : base(nameof(D8), 300, 8) {
            Name.Set(Util.LanguageEnum.Deutsch, "W8");
            Name.Set(Util.LanguageEnum.English, "D8");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}