﻿namespace Exp.Data.General {
    public sealed class DiceTypeData : DataBase {
        #region Properties / Felder
        /// <summary>Anzahl der Seiten des Würfels</summary>
        public int Faces { get; init; }
        #endregion

        #region Konstruktor
        internal DiceTypeData(string aID, int aSortWeight, int aFaces)
            : base(aID, aSortWeight)
            => Faces = aFaces;
        #endregion
    }
}