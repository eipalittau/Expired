namespace Exp.Exception {
    public sealed class DublicateItemException : Exp.Util.ExceptionBase {
        /// <summary>>Das Item mit der ID '{0}' existiert bereits.</summary>
        public DublicateItemException(string aID)
            : base(aID) { }
    }
}