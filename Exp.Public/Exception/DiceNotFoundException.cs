﻿namespace Exp.Exception {
    public sealed class DiceNotFoundException : ExceptionBase {
        /// <summary>Ein {0}-seitiger Würfel ist nicht vorhanden.</summary>
        public DiceNotFoundException(int aFaces)
            : base(aFaces.ToString()) { }
    }
}