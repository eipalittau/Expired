namespace RtD.Exceptions {
    public class DublicateDataException : ExceptionBase {
        public DublicateDataException(string aFieldName, int aID)
            : base(0001, aFieldName, aID.ToString()) { }
    }
}