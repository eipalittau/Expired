namespace RtD.Exceptions {
    public class MissingInstantiationException : ExceptionBase {
        public MissingInstantiationException()
            : base(1001) { }
    }
} // Vor der Verwendung der Klasse '{0}' muss diese instanziert werden.