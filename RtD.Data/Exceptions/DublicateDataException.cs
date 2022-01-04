namespace RtD.Exceptions {
    public class DublicateDataException : ExceptionBase {
        public DublicateDataException(string aFieldName)
            : base(010001, aFieldName) { }
    }
}