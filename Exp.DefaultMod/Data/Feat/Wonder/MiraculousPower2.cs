using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class MiraculousPower2 : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal MiraculousPower2()
            : base(nameof(MiraculousPower2), 1500, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Two)), null, Api.Feat.Wonder.Singleton.Get(nameof(MiraculousPower))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Wundermacht++");
            Name.Set(Util.LanguageEnum.English, "Miraculous power++");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}