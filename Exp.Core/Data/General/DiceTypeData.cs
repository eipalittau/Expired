namespace Exp.Data.General {
    public sealed class DiceTypeData : DataBase {
        #region Properties / Felder
        /// <summary>Anzahl der Seiten des Würfels</summary>
        public int Faces { get; init; }
        #endregion

        #region Konstruktor
        internal DiceTypeData(string aID, int aSortWeight, string aOrigin, int aFaces)
            : base(aID, string.Empty, string.Empty, aSortWeight, aOrigin)
            => Faces = aFaces;
        #endregion
    }
}