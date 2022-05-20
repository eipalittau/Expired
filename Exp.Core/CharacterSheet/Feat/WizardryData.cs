using Exp.Data.Feat.Wizardry;

namespace Exp.Core.Sheet {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class WizardryData : FeatDataBase<IWizardryData> {
        #region Properties / Felder
        public int ManaBonus { get; private set; }
        #endregion

        #region Konstruktor
        internal WizardryData() : base() { }
        #endregion

        #region Methoden
        public new void AddTalent(IWizardryData aTalent) {
            base.AddTalent(aTalent);
        }

        public void LevelUp(IWizardryData aTalent) {
            base.AddTalent(aTalent);
            IncreaseBonus();
        }

        public void IncreaseBonus() {
            ManaBonus++;
        }

        public new IList<IWizardryData> Enumerate() {
            return base.Enumerate();
        }

        public IList<IWizardryData> EnumerateUnused() {
            return Api.Feat.Wizardry.Singleton.Enumerate().Except(Enumerate()).ToList().AsReadOnly();
        }
        #endregion
    }
}