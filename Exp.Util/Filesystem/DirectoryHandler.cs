using System.Reflection;

namespace Exp.Util.Filesystem {
    public static class DirectoryHandler {
        #region CreateDirectory
        public static void CreateDirectory(string aPathName) {
            CreateDirectory(aPathName, false);
        }

        public static void CreateDirectory(string aPathName, bool aCheckPermission) {
            CreateDirectory(new DirectoryInfo(aPathName), false);
        }

        public static void CreateDirectory(DirectoryInfo aPath) {
            CreateDirectory(aPath, false);
        }

        public static void CreateDirectory(DirectoryInfo aPath, bool aCheckPermission) {
            // Verzeichnis erstellen
            try {
                if (!aPath.Exists) {
                    aPath.Create();
                }
            } catch (System.Exception aEx) {
                throw new Exception.Filesystem.DirectoryCreationException(aEx, aPath);
            }

            // Check Permission
            if (aCheckPermission) {
                try {
                    using FileStream lStream = File.Create(Path.Combine(aPath.FullName, "dummy.txt"), 1, FileOptions.DeleteOnClose);
                } catch (System.Exception aEx) {
                    throw new Exception.Filesystem.NoWritePermissionException(aEx, aPath);
                }
            }
        }
        #endregion

        #region GetDirectory
        public static DirectoryInfo GetDirectory() {
            return GetDirectory(Assembly.GetCallingAssembly());
        }

        public static DirectoryInfo GetDirectory(Assembly aAssembly) {
            return new DirectoryInfo(GetDirectoryFromAssembly(aAssembly));
        }

        public static DirectoryInfo GetDirectory(string aAppendDirectory) {
            return GetDirectory(Assembly.GetCallingAssembly(), aAppendDirectory);
        }

        public static DirectoryInfo GetDirectory(Assembly aAssembly, string aAppendDirectory) {
            return new DirectoryInfo(Path.Combine(GetDirectoryFromAssembly(aAssembly), aAppendDirectory));
        }

        private static string GetDirectoryFromAssembly(Assembly aAssembly) {
            return Path.GetDirectoryName(aAssembly.Location) ?? string.Empty;
        }
        #endregion
    }
}