using System.Reflection;

namespace RtD.Components.Filesystem {
    public class Directory {
        public static string GetAssemblyPathName() {
            return GetAssemblyPathName(Assembly.GetExecutingAssembly());
        }

        public static string GetAssemblyPathName(Assembly aUsedAssembly) {
            string? lDirectoryName = Path.GetDirectoryName(aUsedAssembly.Location);

            if (string.IsNullOrEmpty(lDirectoryName)) {
                return string.Empty;
            } else {
                return lDirectoryName;
            }
        }

        public static FileInfo GetAssemblyPathWithFile(string aFileName) {
            return GetAssemblyPathWithFile(Assembly.GetExecutingAssembly(), aFileName);
        }

        public static FileInfo GetAssemblyPathWithFile(Assembly aUsedAssembly, string aFileName) {
            return new FileInfo(Path.Combine(GetAssemblyPathName(aUsedAssembly), aFileName));
        }
    }
}