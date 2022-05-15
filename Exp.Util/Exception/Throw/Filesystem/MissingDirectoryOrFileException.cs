namespace Exp.Exception.Filesystem {
    public class MissingDirectoryOrFileException : ExceptionBase {
        public MissingDirectoryOrFileException(FileInfo aPathFile)
            : base(aPathFile.FullName) { }

        public MissingDirectoryOrFileException(DirectoryInfo aPath)
            : base(aPath.FullName) { }
    }
}