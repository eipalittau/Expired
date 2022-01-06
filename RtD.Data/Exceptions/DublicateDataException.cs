namespace RtD.Exceptions {
    public class DublicateDataException : ExceptionBase {
        public DublicateDataException(string aFieldName)
            : base(0001, aFieldName) { }
    }
}