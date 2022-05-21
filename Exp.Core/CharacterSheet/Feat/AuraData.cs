using Exp.Data.Feat.Aura;

namespace Exp.Core.Sheet {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class AuraData : FeatDataBase<IAuraData> {
        #region Properties / Felder
        public int HealthBonus { get; private set; }
        #endregion

        #region Konstruktor
        internal AuraData(int aMaxLevel) : base(aMaxLevel) { }
        #endregion

        #region Methoden
        public new void AddTalent(IAuraData aFeat) {
            base.AddTalent(aFeat);
        }

        public bool LevelUp(IAuraData aFeat) {
            base.AddTalent(aFeat);
            return IncreaseBonus();
        }

        public bool IncreaseBonus() {
            HealthBonus++;

            return true;
        }

        public new IList<IAuraData> Enumerate() {
            return base.Enumerate();
        }

        public IList<IAuraData> EnumerateUnused() {
            return Api.Feat.Aura.Singleton.Enumerate().Except(Enumerate()).ToList().AsReadOnly();
        }
        #endregion
    }
}