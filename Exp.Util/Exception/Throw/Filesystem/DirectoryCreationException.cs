namespace Exp.Exception.Filesystem {
    public class DirectoryCreationException : ExceptionBase {
        public DirectoryCreationException(System.Exception aEx, DirectoryInfo aPath)
            : base(aEx, aPath.FullName) { }
    }
}