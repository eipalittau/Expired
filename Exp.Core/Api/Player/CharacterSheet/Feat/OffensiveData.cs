using Exp.Data.Feat.Offensive;

namespace Exp.Api.Player.Sheet {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class OffensiveData : FeatDataBase<IOffensiveData> {
        #region Properties / Felder
        public int AttackBonus { get; private set; }
        public int DamageBonus { get; private set; }
        #endregion

        #region Konstruktor
        internal OffensiveData() : base() { }
        #endregion

        #region Methoden
        public new void AddTalent(IOffensiveData aTalent) {
            base.AddTalent(aTalent);
        }

        public void LevelUp(IOffensiveData aTalent) {
            base.AddTalent(aTalent);
            IncreaseBonus();
        }

        public void IncreaseBonus() {
            AttackBonus++;
            DamageBonus++;
        }

        public new IList<IOffensiveData> Enumerate() {
            return base.Enumerate();
        }
        #endregion
    }
}