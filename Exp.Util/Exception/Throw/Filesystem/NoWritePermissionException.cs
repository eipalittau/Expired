namespace Exp.Exception.Filesystem {
    public class NoWritePermissionException : ExceptionBase {
        public NoWritePermissionException(System.Exception aEx, DirectoryInfo aPath)
            : base(aEx, aPath.FullName) { }
    }
}