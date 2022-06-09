namespace Exp.Exception {
    public sealed class DublicateItemException : ExceptionBase {
        /// <summary>>Das Item mit der ID '{0}' existiert bereits.</summary>
        public DublicateItemException(string aID)
            : base(aID) { }

        public DublicateItemException(Type aType)
            : base(aType.Name) { }
    }
}