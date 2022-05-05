namespace Exp.Api.Player.Sheet {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class OffensiveData : FeatDataBase<Data.Feat.IOffensiveData> {
        #region Properties / Felder
        public int AttackBonus { get; private set; }
        public int DamageBonus { get; private set; }
        #endregion

        #region Konstruktor
        internal OffensiveData() : base() { }
        #endregion

        #region Methoden
        public new void AddTalent(Data.Feat.IOffensiveData aTalent) {
            base.AddTalent(aTalent);
        }

        public new void LevelUp(Data.Feat.IOffensiveData aTalent) {
            base.LevelUp(aTalent);
            IncreaseBonus();
        }

        public void IncreaseBonus() {
            AttackBonus++;
            DamageBonus++;
        }

        public new IList<Data.Feat.IOffensiveData> Enumerate() {
            return base.Enumerate();
        }
        #endregion
    }
}