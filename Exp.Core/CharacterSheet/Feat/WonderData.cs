using Exp.Data.Feat.Wonder;

namespace Exp.Core.Sheet {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class WonderData : FeatDataBase<IWonderData> {
        #region Properties / Felder
        public int ManaBonus { get; private set; }
        #endregion

        #region Konstruktor
        internal WonderData() : base() { }
        #endregion

        #region Methoden
        public new void AddTalent(IWonderData aTalent) {
            base.AddTalent(aTalent);
        }

        public void LevelUp(IWonderData aTalent) {
            base.AddTalent(aTalent);
            IncreaseBonus();
        }

        public void IncreaseBonus() {
            ManaBonus++;
        }

        public new IList<IWonderData> Enumerate() {
            return base.Enumerate();
        }

        public IList<IWonderData> EnumerateUnused() {
            return Feat.Wonder.Singleton.Enumerate().Except(Enumerate()).ToList().AsReadOnly();
        }
        #endregion
    }
}