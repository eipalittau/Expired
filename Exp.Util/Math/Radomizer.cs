namespace Exp.Util {
    public static class Radomizer {
        #region Properties / Felder
        private static Random Instance { get; } = new();
        #endregion

        #region Methoden
        public static int Get(int aMax) {
            if (aMax < Constants.Min) {
                ExceptionHandler.Add(new Exception.BadArgumentException(nameof(aMax), aMax));
                return int.MinValue;
            } else {
                if (aMax == Constants.Min) {
                    return aMax;
                } else {
                    return Instance.Next(Constants.Min, aMax);
                }
            }
        }
        #endregion

        private class Constants {
            internal const int Min = 1;
        }
    }
}