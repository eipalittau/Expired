using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class Teamplayer : FeatDataBase<IDefensiveData>, IDefensiveData {
        #region Konstruktor
        internal Teamplayer()
            : base(nameof(Teamplayer), 700, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Teamplayer");
            Name.Set(Util.LanguageEnum.English, "Teamplayer");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}