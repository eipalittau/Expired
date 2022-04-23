namespace Exp.DefaultMod.General {
    internal abstract class DiceTypeBase : DataBase, Data.General.IDiceTypeDataBase {
        #region Properties / Felder
        public int Faces { get; set; }
        #endregion

        #region Konstruktor
        private protected DiceTypeBase(string aID, int aSortWeight, int aFaces)
            : base(aID, aSortWeight)
            => Faces = aFaces;
        #endregion
    }
}