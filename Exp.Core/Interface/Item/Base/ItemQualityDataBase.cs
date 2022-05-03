using Exp.Extension;

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
    }
}