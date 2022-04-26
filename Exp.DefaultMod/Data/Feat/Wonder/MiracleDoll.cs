using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class MiracleDoll : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal MiracleDoll()
            : base(nameof(MiracleDoll), 300, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(Data.General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Wunderpuppe");
            Name.Set(Util.LanguageEnum.English, "Miracle doll");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}