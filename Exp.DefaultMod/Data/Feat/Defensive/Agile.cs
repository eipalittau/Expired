using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class Agile : FeatDataBase<IDefensiveData>, IDefensiveData {
        #region Konstruktor
        internal Agile()
            : base(nameof(Agile), 600, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Agil");
            Name.Set(Util.LanguageEnum.English, "Agile");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}