namespace Exp.Exception {
    /// <summary>>Das Item mit der ID '{0}' kann in der Aufzählung nicht gefunden werden.</summary>
    public sealed class DublicateItemException : ExceptionBase {
        public ItemNotFoundException(string aID)
            : base(aID) { }
    }
}
