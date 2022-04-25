﻿namespace Exp.Data.Equipment {
    public interface IItemQualityDataBase : IDataBase {
        IItemQualityDataBase? Downgrade { get; set; }
        IItemQualityDataBase? Upgrade { get; set; }
        bool CanBeDestroyed { get; set; }
        bool IsDefault { get; set; }
    }
}