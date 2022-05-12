namespace Exp.Exception {
    public sealed class MaximumExceededException : ExceptionBase {
        /// <summary>>Das Maximum von {1} wurde bei '{0}' überschritten.</summary>
        public MaximumExceededException(string aPosition, int aMax)
            : base(aPosition, aMax.ToString()) { }
    }
}