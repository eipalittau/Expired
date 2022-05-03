using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class Dodge : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        internal Dodge()
            : base(nameof(Dodge), 500, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Ausweichen");
            Name.Set(Util.LanguageEnum.English, "Dodge");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}