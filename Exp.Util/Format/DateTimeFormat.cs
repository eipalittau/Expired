namespace Exp.Util {
    public static class DateTimeFormat {
        public static string Full() {
            return Full(Constants.DateTimeSeparator);
        }

        public static string Full(string aSeparator) {
            return string.Concat(DateFormat.Full(), aSeparator, TimeFormat.Full());
        }

        public static string Full4Debug() {
            return Full4Debug(Constants.DateTimeSeparator);
        }

        public static string Full4Debug(string aSeparator) {
            return string.Concat(DateFormat.Full(), aSeparator, TimeFormat.Full4Debug());
        }

        public static string File() {
            return File(string.Empty);
        }

        public static string File(string aSeparator) {
            return string.Concat(DateFormat.File(), aSeparator, TimeFormat.File());
        }

        public static string StatusBar() {
            return StatusBar(String.Space(1));
        }

        public static string StatusBar(string aSeparator) {
            return string.Concat(DateFormat.Full(), aSeparator, TimeFormat.Short());
        }

        private class Constants {
            internal const string DateTimeSeparator = "T";
        }
    }
}