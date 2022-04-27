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

        /// <summary>Fügt das übergebene Item der Sammlung hinzu.</summary>
        /// <param name="aItem">Der neue Datensatz, welcher der Sammlung hinzugefügt werden soll.</param>
        /// <exception cref="DublicateItemException">Falls die ID des Items bereits existiert, wird diese Exception geworfen.</exception>
        private protected void Add(T aItem) {
            if (mDataList.Any(x => x.ID.Equals(aItem.ID, StringComparison.InvariantCultureIgnoreCase))) {
                throw new Exp.Exception.DublicateItemException(aItem.ID);
            }

            mDataList.Add(aItem);
        }
        #endregion
    }
}
