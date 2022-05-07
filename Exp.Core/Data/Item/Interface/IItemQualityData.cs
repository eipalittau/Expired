﻿namespace Exp.Data.Item {
    public interface IItemQualityData : IDataBase {
        IItemQualityData? Downgrade { get; set; }
        IItemQualityData? Upgrade { get; set; }
        bool CanBeDestroyed { get; set; }
        bool IsDefault { get; set; }
        IList<IEffectData> EffectList { get; }

        void AddDownAndUpgrade(string aDowngradeID, string aUpgradeID);
        void AddDowngrade(string aID);
        void AddUpgrade(string aID);
    }
}