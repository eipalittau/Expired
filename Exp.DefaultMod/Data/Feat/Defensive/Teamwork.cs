using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class Teamwork : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        internal Teamwork()
            : base(nameof(Teamwork), 1100, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), null, Api.Feat.Defensive.Singleton.Get(nameof(Teamplayer))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Teamwork");
            Name.Set(Util.LanguageEnum.English, "Teamwork");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}