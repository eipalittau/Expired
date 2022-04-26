using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class StoneSkin : FeatDataBase<IDefensiveData>, IDefensiveData {
        #region Konstruktor
        internal StoneSkin()
            : base(nameof(StoneSkin), 1200, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Two)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Steinhaut");
            Name.Set(Util.LanguageEnum.English, "Stone skin");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}