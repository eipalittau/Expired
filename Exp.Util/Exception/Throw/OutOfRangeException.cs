namespace Exp.Exception {
    /// <summary>Das Argument '{0}' mit dem Wert '{1}' ist verboten.</summary>
    public sealed class OutOfRangeException : ExceptionBase {
        public OutOfRangeException(string aArgumentname, string aValue)
            : base(aArgumentname, aValue) { }

        public OutOfRangeException(string aArgumentname, int aValue)
            : base(aArgumentname, aValue.ToString()) { }
    }
}