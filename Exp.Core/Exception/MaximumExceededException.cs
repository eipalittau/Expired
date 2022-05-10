namespace Exp.Exception {
    public sealed class MaximumExceededException : Exp.Util.ExceptionBase {
        /// <summary>>Das Maximum von {1} wurde bei '{0}' überschritten.</summary>
        public MaximumExceededException(string aPosition, int aMax)
            : base(aPosition, aMax.ToString()) { }
    }
}