using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class Anger : FeatDataBase<IAuraData>, IAuraData {
        #region Konstruktor
        internal Anger()
            : base(nameof(Anger), 600, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), null, Api.Feat.Aura.Singleton.Get(nameof(Fencer)), Api.Feat.Aura.Singleton.Get(nameof(Power))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Aura des Zorns");
            Name.Set(Util.LanguageEnum.English, "Aura of anger");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}