using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Smithing {
    internal sealed class EfficientSmithing2 : SmithingDataBase, ISmithingData {
        #region Konstruktor
        internal EfficientSmithing2()
            : base(nameof(EfficientSmithing2), 1300,
                   Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Two)),
                   Api.Feat.Smithing.Singleton.Get(nameof(EfficientSmithing))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Sehr effizientes Schmieden");
            Name.Set(Util.LanguageEnum.English, "Very efficient smithing");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "");
            EffektDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}