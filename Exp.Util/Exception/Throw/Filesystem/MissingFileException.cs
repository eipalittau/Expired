namespace Exp.Exception.Filesystem {
    public class MissingFileException : ExceptionBase {
        public MissingFileException(FileInfo aPathFile)
            : base(aPathFile.FullName) { }
    }
}