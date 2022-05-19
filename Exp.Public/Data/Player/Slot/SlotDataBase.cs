namespace Exp.Data.Player.Slot {
    public abstract class SlotDataBase : DataBase {
        #region Properties / Felder
        public bool Available { get; set; }
        #endregion

        #region Konstruktor
        protected SlotDataBase(string aID, int aSortWeight, bool aAvailable)
            : base(aID, aSortWeight)
            => Available = aAvailable;
        #endregion

        #region Methoden
        protected static void AddInstance(ISlotData aInstance) {
            Api.Player.Slot.Singleton.Add(aInstance);
        }
        #endregion
    }
}