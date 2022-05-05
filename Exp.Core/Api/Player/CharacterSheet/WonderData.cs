namespace Exp.Api.Player.Sheet {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class WonderData : FeatDataBase<Data.Feat.IWonderData> {
        #region Properties / Felder
        public int ManaBonus { get; private set; }
        #endregion

        #region Konstruktor
        internal WonderData() : base() { }
        #endregion

        #region Methoden
        public new void AddTalent(Data.Feat.IWonderData aTalent) {
            base.AddTalent(aTalent);
        }

        public new void LevelUp(Data.Feat.IWonderData aTalent) {
            base.LevelUp(aTalent);

            ManaBonus++;
        }

        public new IList<Data.Feat.IWonderData> Enumerate() {
            return base.Enumerate();
        }
        #endregion
    }
}