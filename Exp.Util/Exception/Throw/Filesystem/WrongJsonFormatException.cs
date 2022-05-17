namespace Exp.Exception.Filesystem {
    public class WrongJsonFormatException : ExceptionBase {
        public WrongJsonFormatException(System.Exception aEx, FileInfo aJsonPathFile)
            : base(aEx, aJsonPathFile.FullName) { }
    }
}