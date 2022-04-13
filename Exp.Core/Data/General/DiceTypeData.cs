namespace Exp.Data.General {
    public sealed class DiceTypeData : DataBase {
        #region Properties / Felder
        /// <summary>Anzahl der Seiten des Würfels</summary>
        public int Faces { get; init; }
        #endregion

        #region Konstruktor
        internal DiceTypeData(int aID, string aName, string aDescription, uint aSortOrder, string aOrigin, int aFaces)
            : base(aID, aName, aDescription, aSortOrder, aOrigin)
            => Faces = aFaces;
        #endregion
    }
}