using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class Riposte : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        internal Riposte()
            : base(nameof(Riposte), 1600, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Antworten");
            Name.Set(Util.LanguageEnum.English, "Riposte");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}