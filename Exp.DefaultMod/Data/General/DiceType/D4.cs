using Exp.Data.General;

namespace Exp.DefaultMod.General {
    internal sealed class D4 : DiceTypeBase, IDiceTypeData {
        #region Konstruktor
        internal D4()
            : base(nameof(D4), 100, 4) {
            Name.Set(Util.LanguageEnum.Deutsch, "W4");
            Name.Set(Util.LanguageEnum.English, "D4");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}
