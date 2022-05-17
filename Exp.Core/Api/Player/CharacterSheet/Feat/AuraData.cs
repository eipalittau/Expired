using Exp.Data.Feat.Aura;

namespace Exp.Api.Player.Sheet {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class AuraData : FeatDataBase<IAuraData> {
        #region Properties / Felder
        public int HealthBonus { get; private set; }
        #endregion

        #region Konstruktor
        internal AuraData() : base() { }
        #endregion

        #region Methoden
        public new void AddTalent(IAuraData aTalent) {
            base.AddTalent(aTalent);
        }

        public void LevelUp(IAuraData aTalent) {
            base.AddTalent(aTalent);
            IncreaseBonus();
        }

        public void IncreaseBonus() {
            HealthBonus++;
        }

        public new IList<IAuraData> Enumerate() {
            return base.Enumerate();
        }
        #endregion
    }
}