using Exp.Data.Feat.Offensive;
using System.ComponentModel;

namespace Exp.Core.Sheet {
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
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
            return base.Enumerate().AsReadOnly();
        }

        public IList<IOffensiveData> EnumerateUnused() {
            return base.EnumerateUnused(Api.Feat.Offensive.Singleton.Enumerate());
        }
        #endregion
    }
}