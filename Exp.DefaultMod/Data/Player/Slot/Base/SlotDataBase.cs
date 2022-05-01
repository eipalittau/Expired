namespace Exp.DefaultMod.Player.Slot {
    internal abstract class SlotDataBase : DataBase, Exp.Data.Player.ISlotDataBase {
        #region Properties / Felder
        public bool Available { get; set; }
        #endregion

        #region Konstruktor
        private protected SlotDataBase(string aID, int aSortWeight)
            : base(aID, aSortWeight) { }

        private protected SlotDataBase(string aID, int aSortWeight, bool aAvailable)
            : this(aID, aSortWeight)
            => Available = aAvailable;
        #endregion
    }
}