namespace RtD.Exceptions.Json {
    public class WrongJsonFormatException : ExceptionBase {
        public WrongJsonFormatException(System.Exception aEx, string aName)
            : base(1002, aEx, aName) { }
    }
}