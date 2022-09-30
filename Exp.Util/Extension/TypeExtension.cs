namespace Exp.Util.Extension {
    public static class TypeExtension {
        public static string TryGetName(this Type? aData) {
            if (aData is null) {
                return string.Empty;
            } else {
                return aData.FullName ?? aData.Name;
            }
        }
    }
}