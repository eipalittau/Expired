﻿namespace Exp.Exception {
    /// <summary>Das Argument '{0}' mit dem Wert '{1}' ist verboten.</summary>
    public sealed class BadArgumentException : ExceptionBase {
        public BadArgumentException(string aArgumentname, string aValue)
            : base(aArgumentname, aValue) { }

        public BadArgumentException(string aArgumentname, int aValue)
            : base(aArgumentname, aValue.ToString()) { }
    }
}