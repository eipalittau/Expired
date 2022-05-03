using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class Cthulhu : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        internal Cthulhu()
            : base(nameof(Cthulhu), 1800, Api.General.Tier.Singleton.Get(nameof(General.Tier.Three)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Cthulhu");
            Name.Set(Util.LanguageEnum.English, "Cthulhu");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}