using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Smithing {
    internal sealed class Sharpen : FeatDataBase<ISmithingData>, ISmithingData {
        #region Konstruktor
        internal Sharpen()
            : base(nameof(Sharpen), 100, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schärfen");
            Name.Set(Util.LanguageEnum.English, "Sharpen");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}