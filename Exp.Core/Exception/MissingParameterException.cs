namespace Exp.Exception {
    public sealed class MissingParameterException : Exp.Util.ExceptionBase {
        /// <summary>>Für den Parameter '{0}' wurden keine Daten angegeben.</summary>
        public MissingParameterException(string aParameterName)
            : base(aParameterName) { }
    }
}