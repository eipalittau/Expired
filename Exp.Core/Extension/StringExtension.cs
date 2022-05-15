namespace Exp.Util.Extension {
    public static class StringExtension {
        public static bool HasData<T>(this T[] aDatas) {
            return aDatas != null && aDatas.Length > 0;
        }
    }
}