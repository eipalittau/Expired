namespace Exp.Api.Player.Sheet {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class DefensiveData : FeatDataBase<Data.Feat.IDefensiveData> {
        #region Properties / Felder
        public int ArmorClassBonus { get; private set; }
        #endregion

        #region Konstruktor
        internal DefensiveData() : base() { }
        #endregion

        #region Methoden
        public new void AddTalent(Data.Feat.IDefensiveData aTalent) {
            base.AddTalent(aTalent);
        }

        public new void LevelUp(Data.Feat.IDefensiveData aTalent) {
            base.LevelUp(aTalent);
            IncreaseBonus();
        }

        public void IncreaseBonus() {
            ArmorClassBonus++;
        }

        public new IList<Data.Feat.IDefensiveData> Enumerate() {
            return base.Enumerate();
        }
        #endregion
    }
}