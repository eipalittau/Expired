namespace Exp.Util.Extension {
    public static class StringExtension {
        public static bool IsDefaultObject<T>(this T? aData) where T : Data.IDataBase {
            if (aData == null) {
                return false;
            } else {
                return aData.ID.Equals(Public.Properties.Resources.NameDefaultObject, StringComparison.InvariantCultureIgnoreCase);
            }
        }
    }
}