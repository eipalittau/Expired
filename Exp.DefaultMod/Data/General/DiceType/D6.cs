using Exp.Data.General;

namespace Exp.DefaultMod.General {
    internal sealed class D6 : DiceTypeBase, IDiceTypeData {
        #region Konstruktor
        internal D6()
            : base(nameof(D6), 200, 6) {
            Name.Set(Util.LanguageEnum.Deutsch, "W6");
            Name.Set(Util.LanguageEnum.English, "D6");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}