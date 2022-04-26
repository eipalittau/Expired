using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class PreciseShot : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal PreciseShot()
            : base(nameof(PreciseShot), 400, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Präziser Schuss");
            Name.Set(Util.LanguageEnum.English, "Precise shot");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}