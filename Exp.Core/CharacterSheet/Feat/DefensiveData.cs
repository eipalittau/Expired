using Exp.Data.Feat.Defensive;

namespace Exp.Core.Sheet {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class DefensiveData : FeatDataBase<IDefensiveData> {
        #region Properties / Felder
        public int ArmorClassBonus { get; private set; }
        #endregion

        #region Konstruktor
        internal DefensiveData(int aMaxLevel) : base(aMaxLevel) { }
        #endregion

        #region Methoden
        public new void AddTalent(IDefensiveData aTalent) {
            base.AddTalent(aTalent);
        }

        public bool LevelUp(IDefensiveData aTalent) {
            base.AddTalent(aTalent);
            return IncreaseBonus();
        }

        public bool IncreaseBonus() {
            ArmorClassBonus++;

            return true;
        }

        public new IList<IDefensiveData> Enumerate() {
            return base.Enumerate();
        }

        public IList<IDefensiveData> EnumerateUnused() {
            return Api.Feat.Defensive.Singleton.Enumerate().Except(Enumerate()).ToList().AsReadOnly();
        }
        #endregion
    }
}