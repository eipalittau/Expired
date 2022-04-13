using System.Reflection;

namespace Exp.Api {
    public abstract class Base<T> where T : Data.DataBase {
        #region Properties / Felder
        private readonly List<T> mDataList = new();
        #endregion

        #region Konstruktor
        protected Base() { }
        #endregion

        #region Methoden
        protected void Add(T aItem) {
            mDataList.Add(aItem);
        }

        public void Remove(int aID) {
            Remove(Get(aID));
        }

        public void Remove(string aName) {
            Remove(Get(aName));
        }

        public void RemoveDefault() {
            mDataList.Where(x => x.Origin.Equals(GetOriginNameCaller(), StringComparison.InvariantCultureIgnoreCase)).ToList().ForEach(x => Remove(x));
        }

        public IList<T> List() {
            return mDataList.AsReadOnly();
        }

        public T Get(int aID) {
            T? lItem = mDataList.Where(x => x.ID == aID).FirstOrDefault();

            if (lItem == null) {
                // Patrik: Throw Item Not Found Exception
                throw new InvalidOperationException();
            } else {
                return lItem;
            }
        }

        public T Get(string aName) {
            T? lItem = mDataList.Where(x => x.Name.Equals(aName, StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();

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

        protected bool ItemExists(int aID, string aName) {
            return mDataList.Any(x => x.ID == aID || x.Name.Equals(aName, StringComparison.InvariantCultureIgnoreCase));
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