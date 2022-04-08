namespace RtD.Data {
    internal static class Constants {
        public static string Get(int aID, params string[] aArguments) {
            string? lResult = Properties.Resources.ResourceManager.GetString($"CON{aID:D4}");

            if (lResult == null) {
                return string.Empty;
            } else {
                if (aArguments == null) {
                    return lResult;
                } else {
                    return string.Format(lResult, aArguments);
                }
            }
        }

        public static string GetJsonFileName(int aID) {
            return Get(aID, string.Empty);
        }

        public static string GetJsonFileName(int aID, Enumerations.LanguageEnum aLanguage) {
            return Get(aID, $"{aLanguage.ISO}.");
        }
    }
}