using Exp.Data.General;

namespace Exp.DefaultMod.General {
    internal sealed class D10 : DiceTypeBase, IDiceTypeData {
        #region Konstruktor
        internal D10()
            : base(nameof(D10), 400, 10) {
            Name.Set(Util.LanguageEnum.Deutsch, "W10");
            Name.Set(Util.LanguageEnum.English, "D10");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}