using Exp.Data.Feat.Wonder;
using System.ComponentModel;

namespace Exp.Core.Sheet {
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class WonderData : FeatDataBase<IWonderData> {
        #region Properties / Felder
        public int ManaBonus { get; private set; }
        #endregion

        #region Konstruktor
        internal WonderData(int aMaxLevel) : base(aMaxLevel) { }
        #endregion

        #region Methoden
        public new void AddTalent(IWonderData aTalent) {
            base.AddTalent(aTalent);
        }

        public bool LevelUp(IWonderData aTalent) {
            base.AddTalent(aTalent);
            return IncreaseBonus();
        }

        public bool IncreaseBonus() {
            ManaBonus++;

            return true;
        }

        public new IList<IWonderData> Enumerate() {
            return base.Enumerate();
        }

        public IList<IWonderData> EnumerateUnused() {
            return base.EnumerateUnused(Api.Feat.Wonder.Singleton.Enumerate());
        }
        #endregion
    }
}