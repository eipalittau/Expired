using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class Power : FeatDataBase<IAuraData>, IAuraData {
        #region Konstruktor
        internal Power()
            : base(nameof(Power), 200, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Aura der Macht");
            Name.Set(Util.LanguageEnum.English, "Aura of power");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}