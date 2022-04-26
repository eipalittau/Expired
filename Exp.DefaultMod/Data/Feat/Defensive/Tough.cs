using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class Tough : FeatDataBase<IDefensiveData>, IDefensiveData {
        #region Konstruktor
        internal Tough()
            : base(nameof(Tough), 200, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Zäh");
            Name.Set(Util.LanguageEnum.English, "Tough");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}