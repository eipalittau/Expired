using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class Styx : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal Styx()
            : base(nameof(Styx), 1800, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Three)), ActionTypeEnum.Standard) {
            Name.Set(Util.LanguageEnum.Deutsch, "Styx");
            Name.Set(Util.LanguageEnum.English, "Styx");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}