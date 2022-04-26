using Exp.Data.General;

namespace Exp.DefaultMod.General {
    internal sealed class D12 : DiceTypeBase, IDiceTypeData {
        #region Konstruktor
        internal D12()
            : base(nameof(D12), 500, 12) {
            Name.Set(Util.LanguageEnum.Deutsch, "W12");
            Name.Set(Util.LanguageEnum.English, "D12");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}