namespace Exp.Exception {
    /// <summary>Wrapper für System.Exception.</summary>
    public sealed class GeneralException : ExceptionBase {
        public GeneralException(System.Exception aEx)
            : base(aEx) { }
    }
}