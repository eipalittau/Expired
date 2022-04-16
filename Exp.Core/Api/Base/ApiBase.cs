namespace Exp.Api {
    public abstract class ApiBase<T> where T : Data.DataBase {
        #region Properties / Felder
        private readonly List<T> mDataList = new();
        #endregion

        #region Konstruktor
        protected ApiBase() { }
        #endregion

        #region Methoden
        protected void Add(T aItem) {
            if (mDataList.Any(x => x.ID.Equals(aItem.ID, StringComparison.InvariantCultureIgnoreCase))) {
                // Patrik: Throw Dublicate Exception
            }

            mDataList.Add(aItem);
        }

        public void Remove(string aID) {
            mDataList.Remove(Get(aID));
        }

        public void Clear() {
            mDataList.Clear();
        }

        public IList<T> List() {
            return mDataList.AsReadOnly();
        }

        public T Get(string aID) {
            T? lItem = mDataList.Where(x => x.ID.Equals(aID, StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();

            if (lItem == null) {
                // Patrik: Throw Item Not Found Exception
                throw new InvalidOperationException();
            } else {
                return lItem;
            }
        }

        public int Count() {
            return mDataList.Count;
        }
        #endregion
    }
}