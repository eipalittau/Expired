using Exp.Data.General.ActionType;
using Exp.Data.General.Tier;

namespace Exp.Data.Feat {
    public interface IFeatDataBase : IDataBase {
        ITierData Tier { get; set; }
        IActionTypeData? ActionType { get; set; }
        Util.LanguageBasedData EffectDescription { get; }

        string GetEffectDescription();
    }
}