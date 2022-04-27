namespace Exp.Exception {
    /// <summary>>Für den Parameter '{0}' wurden keine Daten angegeben.</summary>
    public sealed class MissingParameterException : ExceptionBase {
        public MissingParameterException(string aParameterName)
            : base(aParameterName) { }
    }
}