using Exp.Api.General;
using Exp.Api.Helper;
using Exp.Data.Player;

namespace Exp.Data.Helper {
    public interface ITargetEffect : IDataBase {
        TargetEffectEnum Effect { get; init; }
        int LapsRemaining { get; set; }
        ModifierData? Increase { get; init; }
        ModifierData? Decrease { get; init; }
        bool IsStackable { get; init; }
        bool HasSaving { get; init; }
        ICharacterSheetData? Owner { get; set; }
    }
}