using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class BrokenWingsGambit : FeatDataBase<IAuraData>, IAuraData {
        #region Konstruktor
        internal BrokenWingsGambit()
            : base(nameof(BrokenWingsGambit), 1000, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(Data.General.ActionType.Free))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Gambit der gebrochenen Flügel");
            Name.Set(Util.LanguageEnum.English, "Broken Wings Gambit");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}