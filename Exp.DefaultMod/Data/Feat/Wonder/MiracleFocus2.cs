using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class MiracleFocus2 : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal MiracleFocus2()
            : base(nameof(MiracleFocus2), 1400, TierEnum.Two, null, Api.Feat.Wonder.Singleton.Get("MiracleFocus")) {
            Name.Set(Util.LanguageEnum.Deutsch, "Wunderfokus++");
            Name.Set(Util.LanguageEnum.English, "Miracle focus++");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}