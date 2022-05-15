using Exp.Util.Extension;

namespace Exp.Data.Item {
    public abstract class ItemQualityDataBase : DataBase {
        #region Properties / Felder
        public IItemQualityData? Downgrade { get; set; }
        public IItemQualityData? Upgrade { get; set; }
        public bool CanBeDestroyed { get; set; }
        public bool IsDefault { get; set; }
        public IList<IEffectData> EffectList {
            get {
                return _EffectList.AsReadOnly();
            }
            init {
                _EffectList = value.ToList();
            }
        }

        private List<IEffectData> _EffectList = new();
        #endregion

        #region Konstruktor
        protected ItemQualityDataBase(string aID, int aSortWeight, bool aCanBeDestroyed, bool aIsDefault, params IEffectData[] aEffects)
            : base(aID, aSortWeight) {
            CanBeDestroyed = aCanBeDestroyed;
            IsDefault = aIsDefault;
            if (aEffects.HasData()) {
                EffectList = aEffects;
            }
        }
        #endregion

        #region Methoden
        public void AddDownAndUpgrade(string aDowngradeID, string aUpgradeID) {
            AddDowngrade(aDowngradeID);
            AddUpgrade(aUpgradeID);
        }

        public void AddDowngrade(string aID) {
            if (!string.IsNullOrEmpty(aID)) {
                Downgrade = Api.Item.ItemQuality.Singleton.Get(aID);
            }
        }

        public void AddUpgrade(string aID) {
            if (!string.IsNullOrEmpty(aID)) {
                Upgrade = Api.Item.ItemQuality.Singleton.Get(aID);
            }
        }

        protected static void AddInstance(IItemQualityData aInstance) {
            Api.Item.ItemQuality.Singleton.Add(aInstance);
        }
        #endregion
    }
}