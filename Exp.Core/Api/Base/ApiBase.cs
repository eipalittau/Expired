namespace Exp.Api {
    public abstract class ApiBase<T> where T : Data.IDataBase {
        #region Properties / Felder
        private readonly List<T> mDataList = new();
        #endregion

        #region Konstruktor
        protected ApiBase() { }
        #endregion

        #region Methoden
        private protected bool Contains(string aID) {
            return mDataList.Where(x => x.ID.Equals(aID, StringComparison.InvariantCultureIgnoreCase)).Any();
        }

        private protected void Remove(string aID) {
            mDataList.Remove(Get(aID));
        }

        private protected void Clear() {
            mDataList.Clear();
        }

        private protected IList<T> Enumerate() {
            return mDataList.AsReadOnly();
        }

        /// <summary>Sucht aufgrund der ID den entsprechenden Datensatz.</summary>
        /// <param name="aID">ID des gesuchten Datensatzes.</param>
        /// <returns>Das gefunden Item.</returns>
        /// <exception cref="DublicateItemException ">Falls die ID des Items nicht existiert, wird diese Exception geworfen.</exception>
        private protected T Get(string aID) {
            T? lItem = mDataList.Where(x => x.ID.Equals(aID, StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();

            if (lItem == null) {
                throw new Exception.ItemNotFoundException(aID);
            } else {
                return lItem;
            }
        }

        /// <summary>Liest die Anzahl der Einträge in der Aufzählung.</summary>
        /// <returns>Die Anzahl der Items in der Aufzählung.</returns>
        private protected int Count() {
            return mDataList.Count;
        }

        /// <summary>Fügt das übergebene Item der Sammlung hinzu.</summary>
        /// <param name="aItem">Der neue Datensatz, welcher der Sammlung hinzugefügt werden soll.</param>
        /// <exception cref="DublicateItemException">Falls die ID des Items bereits existiert, wird diese Exception geworfen.</exception>
        private protected void Add(T aItem) {
            if (mDataList.Any(x => x.ID.Equals(aItem.ID, StringComparison.InvariantCultureIgnoreCase))) {
                throw new Exception.DublicateItemException(aItem.ID);
            }

            mDataList.Add(aItem);
        }

        private IEnumerable<T>? GetItem(string aID) {
            return mDataList.Where(x => x.ID.Equals(aID, StringComparison.InvariantCultureIgnoreCase));
        }
        #endregion
    }
}
