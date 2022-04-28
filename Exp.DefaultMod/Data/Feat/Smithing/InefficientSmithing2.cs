using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Smithing {
    internal sealed class InefficientSmithing2 : SmithingDataBase, ISmithingData {
        #region Konstruktor
        internal InefficientSmithing2()
            : base(nameof(InefficientSmithing2), 1200,
                   Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Two)),
                   Api.Feat.Smithing.Singleton.Get(nameof(InefficientSmithing))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Sehr ineffizientes Schmieden");
            Name.Set(Util.LanguageEnum.English, "Very inefficient smithing");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "");
            EffektDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}