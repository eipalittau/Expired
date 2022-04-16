using System.Reflection;

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
            if (mDataList.Any(x => x.ID == aItem.ID))
            {
                // Patrik: Throw Dublicate Exception
            }

            mDataList.Add(aItem);
        }

        public void Remove(string aID) {
            Remove(Get(aID));
        }

        public void RemoveDefault() {
            mDataList.Where(x => x.Origin.Equals(GetOriginNameExecuting(), StringComparison.InvariantCultureIgnoreCase)).ToList().ForEach(x => Remove(x));
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

        protected string GetOriginNameCaller() {
            return Assembly.GetCallingAssembly().GetName().Name ?? string.Empty;
        }

        protected string GetOriginNameExecuting() {
            return Assembly.GetExecutingAssembly().GetName().Name ?? string.Empty;
        }

        protected bool ItemExists(string aID) {
            return mDataList.Any(x => x.ID.Equals(aID, StringComparison.InvariantCultureIgnoreCase));
        }

        private void Remove(T? aItem) {
            if (aItem == null) {
                // Patrik: Throw Item Not Found Exception
                throw new InvalidOperationException();
            } else {
                mDataList.Remove(aItem);
            }
        }
        #endregion
    }
}