namespace Exp.Extension {
    public static class StringExtension {
        public static bool HasData(this Data.IDataBase[] aDatas) {
            return (aDatas != null && aDatas.Length > 0);
        }
    }
}