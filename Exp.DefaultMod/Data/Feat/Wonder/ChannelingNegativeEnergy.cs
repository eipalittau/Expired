using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class ChannelingNegativeEnergy : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal ChannelingNegativeEnergy()
            : base(nameof(ChannelingNegativeEnergy), 1100, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Two)), Api.General.ActionType.Singleton.Get(nameof(Data.General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Negative Energie Kanalisieren");
            Name.Set(Util.LanguageEnum.English, "Channeling negative energy");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}