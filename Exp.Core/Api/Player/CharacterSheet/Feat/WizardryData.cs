namespace Exp.Api.Player.Sheet {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class WizardryData : FeatDataBase<Data.Feat.IWizardryData> {
        #region Properties / Felder
        public int ManaBonus { get; private set; }
        #endregion

        #region Konstruktor
        internal WizardryData() : base() { }
        #endregion

        #region Methoden
        public new void AddTalent(Data.Feat.IWizardryData aTalent) {
            base.AddTalent(aTalent);
        }

        public void LevelUp(Data.Feat.IWizardryData aTalent) {
            base.AddTalent(aTalent);
            IncreaseBonus();
        }

        public void IncreaseBonus() {
            ManaBonus++;
        }

        public new IList<Data.Feat.IWizardryData> Enumerate() {
            return base.Enumerate();
        }
        #endregion
    }
}