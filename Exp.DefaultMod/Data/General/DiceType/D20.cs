using Exp.Data.General;

namespace Exp.DefaultMod.General {
    internal sealed class D20 : DiceTypeBase, IDiceTypeData {
        #region Konstruktor
        internal D20()
            : base(nameof(D20), 600, 20) {
            Name.Set(Util.LanguageEnum.Deutsch, "W20");
            Name.Set(Util.LanguageEnum.English, "D20");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}