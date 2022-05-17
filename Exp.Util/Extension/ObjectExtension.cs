namespace Exp.Util.Extension {
    public static class ObjectExtension {
        public static string Null2String(this object aData) {
            if (aData != null) {
                string? lResult = aData.ToString();

                if (lResult != null) {
                    return lResult;
                }
            }
            
            return string.Empty;
        }
    }
}