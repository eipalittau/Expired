namespace Exp.Util {
    public abstract class EnumerationMethodBase {
        #region Konstruktor
        protected EnumerationMethodBase() { }
        #endregion

        #region Methoden
        private protected static List<T> Enumerate<T>() where T : EnumerationMethodBase {
            return typeof(T).GetFields()
                .Where(x => x.IsStatic)
                .Where(x => x.IsPublic)
                .Select(x => (T?)x.GetValue(null))
                .OfType<T>().ToList();
        }

        protected static int Count<T>() where T : EnumerationMethodBase {
            return Enumerate<T>().Count;
        }
        #endregion
    }
}