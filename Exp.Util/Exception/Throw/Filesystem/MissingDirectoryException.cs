namespace Exp.Exception.Filesystem {
    public class MissingDirectoryException : ExceptionBase {
        public MissingDirectoryException(DirectoryInfo aPath)
            : base(aPath.FullName) { }
    }
}