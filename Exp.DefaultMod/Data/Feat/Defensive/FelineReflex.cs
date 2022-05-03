using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class FelineReflex : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        internal FelineReflex()
            : base(nameof(FelineReflex), 300, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Katzenreflex");
            Name.Set(Util.LanguageEnum.English, "Feline reflex");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}