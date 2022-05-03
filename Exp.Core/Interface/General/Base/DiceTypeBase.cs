namespace Exp.Data.General {
    public abstract class DiceTypeBase : DataBase {
        #region Properties / Felder
        public int Faces { get; set; }
        #endregion

        #region Konstruktor
        protected DiceTypeBase(string aID, int aSortWeight, int aFaces)
            : base(aID, aSortWeight)
            => Faces = aFaces;

        public int Roll() {
            return new Random().Next(1, Faces);
        }
        #endregion
    }
}