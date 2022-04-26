using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class Anatomy : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal Anatomy()
            : base(nameof(Anatomy), 1400, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Two)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Anatomie");
            Name.Set(Util.LanguageEnum.English, "Anatomy");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}