namespace Exp.Exception {
    /// <summary>Das Argument '{0}' mit dem Wert '{1}' ist verboten.</summary>
    public sealed class OutOfRangeException : ExceptionBase {
        public OutOfRangeException(string aArgumentname, int aValue, int aLowerbound, int aUpperbound)
            : base(aArgumentname, aValue.ToString(), aLowerbound.ToString(), aUpperbound.ToString()) { }
    }
}