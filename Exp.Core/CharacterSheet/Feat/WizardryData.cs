using Exp.Data.Feat.Wizardry;
using System.ComponentModel;

namespace Exp.Core.Sheet {
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
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
            return base.EnumerateUnused(Api.Feat.Wizardry.Singleton.Enumerate());
        }
        #endregion
    }
}