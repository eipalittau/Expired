namespace Exp.Util.Extension {
    public static class DateTimeExtension {
		public static DateTime FirstDayOfMonth(this DateTime aData) {
			return new DateTime(aData.Year, aData.Month, 1);
		}

		public static DateTime LastDayOfMonth(this DateTime aData) {
			return new DateTime(aData.Year, aData.Month + 1, 1).AddDays(-1);
		}

		public static string DateTimeFull(this DateTime aData) {
			return aData.ToString(DateTimeFormat.Full());
		}

		public static string DateTimeFull(this DateTime aData, string aSeparator) {
			return aData.ToString(DateTimeFormat.Full(aSeparator));
		}

		public static string DateTimeFull4Debug(this DateTime aData) {
			return aData.ToString(DateTimeFormat.Full4Debug());
		}

		public static string DateTimeFull4Debug(this DateTime aData, string aSeparator) {
			return aData.ToString(DateTimeFormat.Full4Debug(aSeparator));
		}

		public static string DateTimeFile(this DateTime aData) {
			return aData.ToString(DateTimeFormat.File());
		}

		public static string DateTimeFile(this DateTime aData, string aSeparator) {
			return aData.ToString(DateTimeFormat.File(aSeparator));
		}

		public static string DateTimeStatusBar(this DateTime aData) {
			return aData.ToString(DateTimeFormat.StatusBar());
		}

		public static string DateTimeStatusBar(this DateTime aData, string aSeparator) {
			return aData.ToString(DateTimeFormat.StatusBar(aSeparator));
		}
	}
}