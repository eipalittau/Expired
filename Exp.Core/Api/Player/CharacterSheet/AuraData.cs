namespace Exp.Api.Player.Sheet {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class AuraData : FeatDataBase<Data.Feat.IAuraData> {
        #region Properties / Felder
        public int HealthBonus { get; private set; }
        #endregion

        #region Konstruktor
        internal AuraData() : base() { }
        #endregion

        #region Methoden
        public new void AddTalent(Data.Feat.IAuraData aTalent) {
            base.AddTalent(aTalent);
        }

        public new void LevelUp(Data.Feat.IAuraData aTalent) {
            base.LevelUp(aTalent);

            HealthBonus++;
        }

        public new IList<Data.Feat.IAuraData> Enumerate() {
            return base.Enumerate();
        }
        #endregion
    }
}