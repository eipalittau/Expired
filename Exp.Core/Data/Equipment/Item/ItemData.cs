namespace Exp.Data.Equipment {
    public sealed class ItemData : DataBase {
        #region Properties / Felder
        /// <summary>Anzahl der Seiten des Würfels</summary>
        public int Faces { get; init; }
        #endregion

        #region Konstruktor
        internal ItemData(string aID, int aSortWeight, string aOrigin, int aFaces)
            : base(aID, string.Empty, string.Empty, aSortWeight, aOrigin)
            => Faces = aFaces;
        #endregion
    }
}