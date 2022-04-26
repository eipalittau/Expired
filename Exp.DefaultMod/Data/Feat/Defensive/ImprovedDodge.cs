using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class ImprovedDodge : FeatDataBase<IDefensiveData>, IDefensiveData {
        #region Konstruktor
        internal ImprovedDodge()
            : base(nameof(ImprovedDodge), 1300, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Two)), null, Api.Feat.Defensive.Singleton.Get(nameof(Dodge))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Verbessertes Ausweichen");
            Name.Set(Util.LanguageEnum.English, "Improved dodge");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}