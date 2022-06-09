using Exp.Util.Extension;
using System.ComponentModel;

namespace Exp.Api {
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public abstract class ApiBase<T> where T : Data.IDataBase {
        #region Properties / Felder
        private readonly List<T> mDataList = new();
        #endregion

        #region Konstruktor
        public ApiBase() { }
        #endregion

        #region Methoden
        /// <summary>Fügt das übergebene Item der Sammlung hinzu.</summary>
        /// <param name="aItem">Der neue Datensatz, welcher der Sammlung hinzugefügt werden soll.</param>
        /// <exception cref="DublicateItemException">Falls die ID des Items bereits existiert, wird diese Exception geworfen.</exception>
        private protected void Add(T aItem) {
            if (Contains(aItem.ID)) {
                Util.ExceptionHandler.Add(new Exception.DublicateItemException(aItem.ID));
            } else {
                mDataList.Add(aItem);
            }
        }

        private protected T GetRandom() {
            if (Count() == 0) {
                Exception.EmptyListException lException = new(this.GetType());

                Util.ExceptionHandler.Add(lException);
                throw lException;
            } else {
                return Enumerate().ElementAt(Util.Radomizer.Get(Count()));
            }
        }

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

        private protected List<T> Enumerate() {
            return mDataList
                .Where(x => !x.IsDefaultObject())
                .ToList();
        }

        /// <summary>Sucht aufgrund der ID den entsprechenden Datensatz.</summary>
        /// <param name="aID">ID des gesuchten Datensatzes.</param>
        /// <returns>Das gefunden Item.</returns>
        /// <exception cref="ItemNotFoundException ">Falls die ID des Items nicht existiert, wird diese Exception geworfen.</exception>
        private protected T Get(string aID) {
            T? lItem = GetItem(aID).FirstOrDefault();

            if (lItem == null) {
                Util.ExceptionHandler.Add(new Exception.ItemNotFoundException(aID));

                lItem = GetDefault();
            }

            return lItem;
        }

        /// <summary>Sucht aufgrund des Indexes den entsprechenden Datensatz.</summary>
        /// <param name="aIndex"></param>
        /// <returns>Das gefunden Item.</returns>
        private protected T Get(int aIndex) {
            if (aIndex < 0 || aIndex > mDataList.Count) {
                Util.ExceptionHandler.Add(new Exception.OutOfRangeException(nameof(aIndex), aIndex, 0, mDataList.Count));

                return GetDefault();
            } else {
                return Enumerate()[aIndex];
            }
        }

        /// <summary>Liest die Anzahl der Einträge in der Aufzählung.</summary>
        /// <returns>Die Anzahl der Items in der Aufzählung.</returns>
        private protected int Count() {
            return Enumerate().Count;
        }

        private IEnumerable<T> GetItem(string aID) {
            return mDataList.Where(x => x.ID.Equals(aID, StringComparison.InvariantCultureIgnoreCase));
        }

        private T GetDefault() {
            T? lItem = GetItem(Public.Properties.Resources.NameDefaultObject).FirstOrDefault();

            if (lItem == null) {
                Exception.MissingInitializationException lException = new();

                Util.ExceptionHandler.Add(lException);
                throw lException;
            }

            return lItem;
        }
        #endregion
    }
}
