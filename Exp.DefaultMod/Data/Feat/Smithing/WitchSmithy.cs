using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Smithing {
    internal sealed class WitchSmithy : SmithingDataBase, ISmithingData {
        #region Konstruktor
        internal WitchSmithy()
            : base(nameof(WitchSmithy), 1500, Api.General.Tier.Singleton.Get(nameof(Exp.Data.General.Tier.Three)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Hexenschmiede");
            Name.Set(Util.LanguageEnum.English, "Witch smithy");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "");
            EffektDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}