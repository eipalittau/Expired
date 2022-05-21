using Exp.Data.Feat.Wizardry;

namespace Exp.Core.Sheet {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class WizardryData : FeatDataBase<IWizardryData> {
        #region Properties / Felder
        public int ManaBonus { get; private set; }
        #endregion

        #region Konstruktor
        internal WizardryData(int aMaxLevel) : base(aMaxLevel) { }
        #endregion

        #region Methoden
        public new void AddTalent(IWizardryData aTalent) {
            base.AddTalent(aTalent);
        }

        public bool LevelUp(IWizardryData aTalent) {
            base.AddTalent(aTalent);
            return IncreaseBonus();
        }

        public bool IncreaseBonus() {
            ManaBonus++;

            return true;
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