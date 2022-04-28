namespace Exp.Extension {
    public static class StringExtension {
        public static bool HasData(this Data.IDataBase[] aDatas) {
            return HasData<Data.IDataBase>(aDatas);
        }

        public static bool HasData<T>(this T[] aDatas) {
            return aDatas != null && aDatas.Length > 0;
        }
    }
}