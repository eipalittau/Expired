using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class RoadRunner : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        internal RoadRunner()
            : base(nameof(RoadRunner), 1500, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Road runner");
            Name.Set(Util.LanguageEnum.English, "Straßenläufer");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}