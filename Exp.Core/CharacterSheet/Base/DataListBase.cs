using Exp.Api.General;
using System.ComponentModel;

namespace Exp.Core.Sheet {
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public abstract class DataListBase<T> where T : SheetBase {
        #region Properties / Felder
        private readonly List<T> mDataList = new();
        #endregion

        #region Konstruktor
        private protected DataListBase() { }
        #endregion

        #region Methoden
        private protected void Add(T aItem) {
            if (mDataList.Contains(aItem)) {
                Util.ExceptionHandler.Add(new Exception.DublicateItemException(aItem.GetType()));
            } else {
                mDataList.Add(aItem);
            }
        }

        internal int Count() {
            return mDataList.Count;
        }

        private protected T Get(Func<T, bool> aPredicate) {
            return mDataList.First(aPredicate);
        }

        internal IList<T> Enumerate() {
            return mDataList.AsReadOnly();
        }

        internal void LevelUp(TargetEffectEnum aEffect) {
            mDataList.ForEach(x => x.LevelUp(aEffect));
        }

        internal void OnNewDay() {
            mDataList.ForEach(x => x.OnNewDay());
        }
        #endregion
    }
}