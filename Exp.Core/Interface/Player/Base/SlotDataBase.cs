namespace Exp.Data.Player {
    public abstract class SlotDataBase : DataBase {
        #region Properties / Felder
        public bool Available { get; set; }
        #endregion

        #region Konstruktor
        protected SlotDataBase(string aID, int aSortWeight, bool aAvailable)
            : base(aID, aSortWeight)
            => Available = aAvailable;
        #endregion
    }
}