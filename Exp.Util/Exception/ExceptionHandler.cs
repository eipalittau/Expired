using Exp.Exception;

namespace Exp.Util {
    public static class ExceptionHandler {
        #region Properties / Felder
        public static bool ThrowException { get; set; }
        private static List<ExceptionBase> ExceptionList { get; } = new List<ExceptionBase>();
        #endregion

        #region Methoden
        public static void Add(ExceptionBase aEx) {
            if (ThrowException) {
                throw aEx;
            } else {
                ExceptionList.Add(aEx);
            }
        }

        public static IList<ExceptionBase> GetExceptionList() {
            return ExceptionList.AsReadOnly();
        }

        public static int Count() {
            return ExceptionList.Count;
        }

        public static void Clear() {
            ExceptionList.Clear();
        }
        #endregion
    }
}