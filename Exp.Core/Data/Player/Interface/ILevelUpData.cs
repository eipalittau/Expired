﻿namespace Exp.Data.Player {
    public interface ILevelUpData : IDataBase {
        Api.General.TargetEffectEnum Changer { get; init; }
        Api.Helper.ModifierData Base { get; init; }
    }
}