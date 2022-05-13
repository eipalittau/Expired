namespace Exp.Util {
    public static class TimeFormat {
        public static string Full() {
            return "HH:mm:ss";
        }

        public static string Full4Debug() {
            return "HH:mm:ss.ffff";
        }

        public static string File() {
            return "HHmm";
        }

        public static string Short() {
            return "HH:mm";
        }
    }
}