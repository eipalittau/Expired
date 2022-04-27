namespace Exp.Exception {
    /// <summary>>Das Item mit der ID '{0}' existiert bereits.</summary>
    public sealed class DublicateItemException : ExceptionBase {
        public DublicateItemException(string aID)
            : base(aID) { }
    }
}
