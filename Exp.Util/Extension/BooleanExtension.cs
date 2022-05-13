namespace Exp.Util.Extension {
    public static class BooleanExtension {
        public static string ToString(this bool aData, string aTrueValue, string aFalseValue) {
            return aData ? aTrueValue : aFalseValue;
        }

        public static string ToString(this bool aData) {
            return aData.ToString("true", "false");
        }
    }
}