using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Smithing {
    internal sealed class InefficientSmithing : SmithingDataBase, ISmithingData {
        #region Konstruktor
        internal InefficientSmithing()
            : base(nameof(InefficientSmithing), 700, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Ineffizientes Schmieden");
            Name.Set(Util.LanguageEnum.English, "Inefficient smithing");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "");
            EffektDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}