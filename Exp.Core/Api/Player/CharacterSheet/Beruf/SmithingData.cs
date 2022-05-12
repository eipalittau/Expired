using Exp.Data.Profession;

namespace Exp.Api.Player.Sheet {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class SmithingData : FeatDataBase<ISmithingData> {
        #region Konstruktor
        internal SmithingData()
            : base()
            => MaxLevel = 5;
        #endregion

        #region Methoden
        public new void AddTalent(ISmithingData aTalent) {
            base.AddTalent(aTalent);
        }

        public new IList<ISmithingData> Enumerate() {
            return base.Enumerate();
        }
        #endregion
    }
}