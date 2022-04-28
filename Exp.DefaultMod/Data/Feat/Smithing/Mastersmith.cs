using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Smithing {
    internal sealed class Mastersmith : SmithingDataBase, ISmithingData {
        #region Konstruktor
        internal Mastersmith()
            : base(nameof(Mastersmith), 1400, Api.General.Tier.Singleton.Get(nameof(Exp.Data.General.Tier.Three)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Meisterschmied");
            Name.Set(Util.LanguageEnum.English, "Mastersmith");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "");
            EffektDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}