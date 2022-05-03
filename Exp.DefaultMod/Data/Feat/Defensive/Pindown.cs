using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class Pindown : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        internal Pindown()
            : base(nameof(Pindown), 800, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Anpinnen");
            Name.Set(Util.LanguageEnum.English, "Pindown");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}