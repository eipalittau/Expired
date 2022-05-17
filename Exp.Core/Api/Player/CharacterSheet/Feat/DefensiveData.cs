using Exp.Data.Feat.Defensive;

namespace Exp.Api.Player.Sheet {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class DefensiveData : FeatDataBase<IDefensiveData> {
        #region Properties / Felder
        public int ArmorClassBonus { get; private set; }
        #endregion

        #region Konstruktor
        internal DefensiveData() : base() { }
        #endregion

        #region Methoden
        public new void AddTalent(IDefensiveData aTalent) {
            base.AddTalent(aTalent);
        }

        public void LevelUp(IDefensiveData aTalent) {
            base.AddTalent(aTalent);
            IncreaseBonus();
        }

        public void IncreaseBonus() {
            ArmorClassBonus++;
        }

        public new IList<IDefensiveData> Enumerate() {
            return base.Enumerate();
        }
        #endregion
    }
}