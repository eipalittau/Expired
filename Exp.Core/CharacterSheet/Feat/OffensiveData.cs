using Exp.Data.Feat.Offensive;

namespace Exp.Core.Sheet {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class OffensiveData : FeatDataBase<IOffensiveData> {
        #region Properties / Felder
        public int AttackBonus { get; private set; }
        public int DamageBonus { get; private set; }
        #endregion

        #region Konstruktor
        internal OffensiveData(int aMaxLevel) : base(aMaxLevel) { }
        #endregion

        #region Methoden
        public new void AddTalent(IOffensiveData aTalent) {
            base.AddTalent(aTalent);
        }

        public bool LevelUp(IOffensiveData aTalent) {
            base.AddTalent(aTalent);
            return IncreaseBonus();
        }

        public bool IncreaseBonus() {
            AttackBonus++;
            DamageBonus++;

            return true;
        }

        public new IList<IOffensiveData> Enumerate() {
            return base.Enumerate();
        }

        public IList<IOffensiveData> EnumerateUnused() {
            return Api.Feat.Offensive.Singleton.Enumerate().Except(Enumerate()).ToList().AsReadOnly();
        }
        #endregion
    }
}