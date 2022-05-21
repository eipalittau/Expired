using Exp.Util;

namespace Exp.Core.Sheet {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public abstract class FeatDataBase<T> where T : Data.IDataBase {
        #region Properties / Felder
        public int Level { get; private set; } = 0;
        public int MaxLevel { get; init; }
        private List<T> FeatList { get; } = new List<T>();
        #endregion

        #region Konstruktor
        private protected FeatDataBase(int aMaxLevel)
            => MaxLevel = aMaxLevel;
        #endregion

        #region Methoden
        public int Count() {
            return FeatList.Count;
        }

        private protected IList<T> Enumerate() {
            return FeatList.AsReadOnly();
        }

        private protected void AddTalent(T aTalent) {
            if (FeatList.Contains(aTalent)) {
                ExceptionHandler.Add(new Exception.DublicateItemException(aTalent.ID));
            } else {
                FeatList.Add(aTalent);
            }
        }
        #endregion
    }
}