using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class EloquentInsulte : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        internal EloquentInsulte()
            : base(nameof(EloquentInsulte), 300, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Eloquent beleidigen");
            Name.Set(Util.LanguageEnum.English, "Eloquent insulte");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}