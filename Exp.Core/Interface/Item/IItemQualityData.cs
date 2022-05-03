namespace Exp.Data.Item {
    public interface IItemQualityData : IDataBase {
        IItemQualityData? Downgrade { get; set; }
        IItemQualityData? Upgrade { get; set; }
        bool CanBeDestroyed { get; set; }
        bool IsDefault { get; set; }
        IList<IEffectData> EffectList { get; }
    }
}