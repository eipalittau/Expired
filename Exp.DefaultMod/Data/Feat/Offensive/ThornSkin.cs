using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class ThornSkin : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal ThornSkin()
            : base(nameof(ThornSkin), 1700, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Two)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Dornenhaut");
            Name.Set(Util.LanguageEnum.English, "Thorn skin");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}