﻿using Exp.Api.General;
using Exp.Api.Helper;
using Exp.Data.General;
using Exp.Data.Helper;

namespace Exp.Data.Misc {
    public interface IAptitudeData : IDataBase {
        ModifierData Base { get; init; }
        ModifierData Modifier { get; init; }
        ModifierData Multiplicator { get; init; }
        ModifierData Divisor { get; init; }
        TargetEffectEnum Effect { get; init; }
        IActionTypeData? ActionType { get; init; }

        IList<ITargetEffect> Execute();
    }
}