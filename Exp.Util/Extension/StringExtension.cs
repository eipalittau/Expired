using System.Text.RegularExpressions;

namespace Exp.Util.Extension {
    public static class StringExtension {
        #region HasData
        /// <summary>Prüft den String-Array auf Daten.</summary>
        /// <param name="aDatas"></param>
        /// <returns>True: Wenn mindestens 1 Element vorhanden ist.
        /// False: Wenn das Objekt Null ist, oder keine Elemente enthält.</returns>
        public static bool HasData(this string[] aDatas) {
            return aDatas?.Length > 0;
        }

        /// <summary>Prüft den Char-Array auf Daten.</summary>
        /// <param name="aDatas"></param>
        /// <returns>True: Wenn mindestens 1 Element vorhanden ist.
        /// False: Wenn das Objekt Null ist, oder keine Elemente enthält.</returns>
        public static bool HasData(this char[] aDatas) {
            return aDatas?.Length > 0;
        }

        /// <summary>Prüft den Objekt-Array auf Daten.</summary>
        /// <param name="aDatas"></param>
        /// <returns>True: Wenn mindestens 1 Element vorhanden ist.
        /// False: Wenn das Objekt Null ist, oder keine Elemente enthält.</returns>
        public static bool HasData<T>(this T[] aDatas) {
            return aDatas?.Length > 0;
        }
        #endregion

        #region Is...
        /// <summary>Prüft, ob der String in Boolean ist. Mögliche Werte: "false", "no", "nein", "f", "n", "0", "true", "yes", "ja", "t", "y", "j", "1", "-1"</summary>
        /// <param name="aData"></param>
        /// <returns>True: Der String ist ein boolean.
        /// False: Der String ist kein boolean.</returns>
        public static bool IsBoolean(this string aData) {
            return aData.EqualsAny("false", "no", "nein", "f", "n", "0", "true", "yes", "ja", "t", "y", "j", "1", "-1");
        }

        public static bool IsNumeric(this string aData) {
            return decimal.TryParse(aData, out _);
        }

        public static bool IsDate(this string aData) {
            if (string.IsNullOrEmpty(aData)) {
                return false;
            } else {
                return DateTime.TryParse(aData, out _);
            }
        }

        public static bool IsValidEmailAddress(this string aData) {
            return aData.IsMatch(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
        }

        public static bool IsGuid(this string aData) {
            Regex lFormat = new("^[A-Fa-f0-9]{32}$|" +
                "^({|\\()?[A-Fa-f0-9]{8}-([A-Fa-f0-9]{4}-){3}[A-Fa-f0-9]{12}(}|\\))?$|" +
                "^({)?[0xA-Fa-f0-9]{3,10}(, {0,1}[0xA-Fa-f0-9]{3,6}){2}, {0,1}({)([0xA-Fa-f0-9]{3,4}, {0,1}){7}[0xA-Fa-f0-9]{3,4}(}})$");

            return lFormat.Match(aData).Success;
        }

        public static bool IsValidUrl(this string aData) {
            return aData.IsMatch(@"http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?");
        }

        public static bool IsValidIP(this string aData) {
            return aData.IsMatch(@"^(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])$");
        }

        public static bool IsMatch(this string aData, string aRegex) {
            return new Regex(aRegex).IsMatch(aData);
        }
        #endregion

        public static bool EqualsAny(this string aData, params string[] aValues) {
            if (aValues.HasData()) {
                return aValues.Any(x => aData.Equals(x, StringComparison.InvariantCultureIgnoreCase));
            }

            return false;
        }

        public static bool ContainsAll(this string aData, params string[] aValues) {
            if (aValues.HasData()) {
                foreach (string lValue in aValues) {
                    if (!aData.Contains(lValue, StringComparison.InvariantCultureIgnoreCase)) {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool ContainsAny(this string aData, params char[] aToFind) {
            if (aToFind.HasData()) {
                return aToFind.Any(x => aData.Contains(x, StringComparison.InvariantCultureIgnoreCase));
            }

            return false;
        }

        public static bool ContainsAny(this string aData, params string[] aToFind) {
            if (aToFind.HasData()) {
                return aToFind.Any(x => aData.Contains(x, StringComparison.InvariantCultureIgnoreCase));
            }

            return false;
        }

        public static string ExtractNumber(this string aData) {
            return new string(aData.ToCharArray().Where(x => char.IsNumber(x)).ToArray());
        }

        public static FileInfo ToFileInfo(this string aData) {
            return new FileInfo(aData);
        }

        public static bool In(this string aData, params string[] aValues) {
            return Array.IndexOf(aValues, aData) != -1;
        }
    }
}