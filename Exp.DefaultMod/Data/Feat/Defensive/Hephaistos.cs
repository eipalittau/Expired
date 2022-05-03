using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class Hephaistos : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        internal Hephaistos()
            : base(nameof(Hephaistos), 1700, Api.General.Tier.Singleton.Get(nameof(General.Tier.Three)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Hephaistos");
            Name.Set(Util.LanguageEnum.English, "Hephaistos");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}