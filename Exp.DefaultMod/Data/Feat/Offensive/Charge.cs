using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class Charge : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal Charge()
            : base(nameof(Charge), 600, TierEnum.One, ActionTypeEnum.Full) {
            Name.Set(Util.LanguageEnum.Deutsch, "CHARGE!");
            Name.Set(Util.LanguageEnum.English, "CHARGE!");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}