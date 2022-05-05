namespace Exp.Api.Player.Sheet {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class SmithingData : FeatDataBase<Data.Feat.ISmithingData> {
        #region Konstruktor
        internal SmithingData() : base() { }
        #endregion

        #region Methoden
        public new void AddTalent(Data.Feat.ISmithingData aTalent) {
            base.AddTalent(aTalent);
        }

        public new void LevelUp(Data.Feat.ISmithingData aTalent) {
            base.LevelUp(aTalent);
        }

        public new IList<Data.Feat.ISmithingData> Enumerate() {
            return base.Enumerate();
        }
        #endregion
    }
}