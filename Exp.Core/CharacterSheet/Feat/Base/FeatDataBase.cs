using Exp.Util;
using System.ComponentModel;

namespace Exp.Core.Sheet {
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public abstract class FeatDataBase<T> where T : Data.IDataBase {
        #region Properties / Felder
        public int Level { get; private set; } = 0;
        public int MaxLevel { get; init; }

        private readonly List<T> mDataList = new();
        #endregion

        #region Konstruktor
        private protected FeatDataBase(int aMaxLevel)
            => MaxLevel = aMaxLevel;
        #endregion

        #region Methoden
        public int Count() {
            return mDataList.Count;
        }

        private protected List<T> Enumerate() {
            return mDataList;
        }

        private protected IList<T> EnumerateUnused(IList<T> aMainList) {
            return aMainList.Except(Enumerate()).ToList().AsReadOnly();
        }

        private protected void AddTalent(T aTalent) {
            if (mDataList.Contains(aTalent)) {
                ExceptionHandler.Add(new Exception.DublicateItemException(aTalent.ID));
            } else {
                mDataList.Add(aTalent);
            }
        }
        #endregion
    }
}