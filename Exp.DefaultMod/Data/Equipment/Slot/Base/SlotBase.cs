namespace Exp.DefaultMod.Equipment {
    internal abstract class SlotBase : DataBase, Data.Equipment.ISlotDataBase {
        #region Properties / Felder
        public bool Available { get; set; }
        #endregion

        #region Konstruktor
        private protected SlotBase(string aID, int aSortWeight)
            : base(aID, aSortWeight) { }

        private protected SlotBase(string aID, int aSortWeight, bool aAvailable)
            : this(aID, aSortWeight)
            => Available = aAvailable;
        #endregion
    }
}