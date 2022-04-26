using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class DangerInstinct : FeatDataBase<IDefensiveData>, IDefensiveData {
        #region Konstruktor
        internal DangerInstinct()
            : base(nameof(DangerInstinct), 400, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Gefahreninstinkt");
            Name.Set(Util.LanguageEnum.English, "Danger instinct");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}