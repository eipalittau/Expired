namespace Exp.Api {
    public abstract class ApiBase<T> where T : Data.IDataBase {
        #region Properties / Felder
        private readonly List<T> mDataList = new();
        #endregion

        #region Konstruktor
        protected ApiBase() { }
        #endregion

        #region Methoden
        private protected void Remove(string aID) {
            mDataList.Remove(Get(aID));
        }

        private protected void Clear() {
            mDataList.Clear();
        }

        private protected IList<T> List() {
            return mDataList.AsReadOnly();
        }

        private protected T Get(string aID) {
            T? lItem = mDataList.Where(x => x.ID.Equals(aID, StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();

            if (lItem == null) {
                // Patrik: Throw Item Not Found Exception
                throw new InvalidOperationException();
            } else {
                return lItem;
            }
        }

        private protected int Count() {
            return mDataList.Count;
        }

        private protected void Add(T aItem) {
            if (mDataList.Any(x => x.ID.Equals(aItem.ID, StringComparison.InvariantCultureIgnoreCase))) {
                // Patrik: Throw Dublicate Exception
            }

            mDataList.Add(aItem);
        }
        #endregion
    }
}