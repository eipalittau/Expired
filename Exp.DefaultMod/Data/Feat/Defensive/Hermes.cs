using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class Hermes : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        internal Hermes()
            : base(nameof(Hermes), 1600, Api.General.Tier.Singleton.Get(nameof(General.Tier.Three)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Hermes");
            Name.Set(Util.LanguageEnum.English, "Hermes");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}