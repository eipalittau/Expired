namespace Exp.Exception {
    public sealed class ItemNotFoundException : Exp.Util.ExceptionBase {
        /// <summary>>Das Item mit der ID '{0}' kann in der Aufzählung nicht gefunden werden.</summary>
        public ItemNotFoundException(string aID)
            : base(aID) { }
    }
}