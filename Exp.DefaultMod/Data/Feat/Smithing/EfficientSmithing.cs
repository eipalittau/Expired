using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Smithing {
    internal sealed class EfficientSmithing : SmithingDataBase, ISmithingData {
        #region Konstruktor
        internal EfficientSmithing()
            : base(nameof(EfficientSmithing), 800, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Effizientes Schmieden");
            Name.Set(Util.LanguageEnum.English, "Efficient smithing");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "");
            EffektDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}