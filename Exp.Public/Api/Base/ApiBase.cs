using Exp.Util;
using Exp.Util.Extension;

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

        private protected void Remove(string aID) {
            T? lItem = Get(aID);

            if (lItem != null && !lItem.IsDefaultObject()) {
                mDataList.Remove(lItem);
            }
        }

        private protected void Clear() {
            mDataList.Clear();
        }

        private protected IList<T> Enumerate() {
            return GetItems().AsReadOnly();
        }

        /// <summary>Sucht aufgrund der ID den entsprechenden Datensatz.</summary>
        /// <param name="aID">ID des gesuchten Datensatzes.</param>
        /// <returns>Das gefunden Item.</returns>
        /// <exception cref="ItemNotFoundException ">Falls die ID des Items nicht existiert, wird diese Exception geworfen.</exception>
        private protected T Get(string aID) {
            T? lItem = GetItem(aID).FirstOrDefault();

            if (lItem == null) {
                ExceptionHandler.Add(new Exception.ItemNotFoundException(aID));

                lItem = GetItem(Public.Properties.Resources.NameDefaultObject).FirstOrDefault();
                if (lItem == null) {
                    Exception.ItemNotFoundException lException = new(aID);

                    ExceptionHandler.Add(lException);
                    throw lException;
                }
            }

            return lItem;
        }

        /// <summary>Sucht aufgrund des Indexes den entsprechenden Datensatz.</summary>
        /// <param name="aIndex"></param>
        /// <returns>Das gefunden Item.</returns>
        private protected T Get(int aIndex) {
            if (aIndex < 0 || aIndex > mDataList.Count) {
                ExceptionHandler.Add(new Exception.OutOfRangeException(nameof(aIndex), aIndex, 0, mDataList.Count));

                return Get(Public.Properties.Resources.NameDefaultObject);
            } else {
                return GetItems()[aIndex];
            }
        }

        /// <summary>Liest die Anzahl der Einträge in der Aufzählung.</summary>
        /// <returns>Die Anzahl der Items in der Aufzählung.</returns>
        private protected int Count() {
            return GetItems().Count;
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

        private List<T> GetItems() {
            return mDataList
                .Where(x => !x.IsDefaultObject())
                .ToList();
        }
        #endregion
    }
}
