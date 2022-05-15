using Exp.Util;

namespace Exp.Api {
    public abstract class ApiBase<T> where T : Data.IDataBase {
        #region Properties / Felder
        private readonly List<T> mDataList = new();
        #endregion

        #region Konstruktor
        public ApiBase() { }
        #endregion

        #region Methoden
        private protected bool Contains(string aID) {
            return GetItem(aID).Any();
        }

        //Patrik: Neuer Get berücksichtigen
        private protected void Remove(string aID) {
            T? lItem = Get(aID);

            if (lItem != null) {
                mDataList.Remove(lItem);
            }
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
            T? lItem = GetItem(aID).FirstOrDefault();

            if (lItem == null) {
                ExceptionHandler.Add(new Exception.ItemNotFoundException(aID));
                lItem = mDataList.First();
            }

            return lItem;
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
            if (Contains(aItem.ID)) {
                ExceptionHandler.Add(new Exception.DublicateItemException(aItem.ID));
            } else {
                mDataList.Add(aItem);
            }
        }

        private IEnumerable<T> GetItem(string aID) {
            return mDataList.Where(x => x.ID.Equals(aID, StringComparison.InvariantCultureIgnoreCase));
        }
        #endregion
    }
}
