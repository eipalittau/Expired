using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class Shadowy : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        internal Shadowy()
            : base(nameof(Shadowy), 900, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schattenhaft");
            Name.Set(Util.LanguageEnum.English, "Shadowy");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}