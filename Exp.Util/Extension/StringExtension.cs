using System.Text.RegularExpressions;

namespace Exp.Util.Extension {
    public static class StringExtension {
        public static bool HasData(this string[] aDatas) {
            return aDatas != null && aDatas.Length > 0;
        }

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

        public static bool EqualsAny(this string aData, params string[] aValues) {
            if (aValues != null && aValues.Length > 0) {
                return aValues.Where(x => aData.Equals(x, StringComparison.InvariantCultureIgnoreCase)).Any();
            }

            return false;
        }

        public static bool ContainsAll(this string aData, params string[] aValues) {
            if (aValues != null && aValues.Length > 0) {
                foreach (string lValue in aValues) {
                    if (!aData.Contains(lValue, StringComparison.InvariantCultureIgnoreCase)) {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool ContainsAny(this string aData, params char[] aToFind) {
            if (aToFind != null && aToFind.Length > 0) {
                return aToFind.Where(x => aData.Contains(x, StringComparison.InvariantCultureIgnoreCase)).Any();
            }

            return false;
        }

        public static bool ContainsAny(this string aData, params string[] aToFind) {
            if (aToFind != null && aToFind.Length > 0) {
                return aToFind.Where(x => aData.Contains(x, StringComparison.InvariantCultureIgnoreCase)).Any();
            }

            return false;
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

        public static string ExtractNumber(this string aData) {
            return new string(aData.ToCharArray().Where(x => char.IsNumber(x)).ToArray());
        }
        
        public static T ToEnum<T>(this string aData) {
            return (T)Enum.Parse(typeof(T), aData);
        }

        public static FileInfo ToFileInfo(this string aData) {
            return new FileInfo(aData);
        }

        public static bool In(this string aData, params string[] aValues) {
            return Array.IndexOf(aValues, aData) != -1;
        }

        public static bool IsMatch(this string aData, string aRegex) {
            return new Regex(aRegex).IsMatch(aData);
        }

        public static string Space(int aCount) {
            return new string(' ', aCount);
        }
    }
}