using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class Mob : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal Mob()
            : base(nameof(Mob), 1200, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Two)), Api.General.ActionType.Singleton.Get(nameof(Data.General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Horde");
            Name.Set(Util.LanguageEnum.English, "Mob");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}