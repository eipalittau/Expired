using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class MiraculousPower : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal MiraculousPower()
            : base(nameof(MiraculousPower), 800, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Wundermacht");
            Name.Set(Util.LanguageEnum.English, "Miraculous power");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}