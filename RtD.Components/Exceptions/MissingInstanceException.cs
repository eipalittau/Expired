namespace RtD.Exceptions {
    public class MissingInstanceException : ExceptionBase {
        public MissingInstanceException(string aClassName)
            : base(000001, aClassName) { }
    }
}