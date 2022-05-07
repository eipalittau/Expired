namespace Exp.Util.Extension {
    public static class StringExtension {
        public static bool HasData(this string[] aDatas) {
            return aDatas != null && aDatas.Length > 0;
        }
    }
}