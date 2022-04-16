namespace Exp.Data.Equipment {
    public sealed class SlotData : DataBase {
        #region Properties / Felder
        /// <summary>Definiert, ob der Slot verfügbar ist.</summary>
        public bool Available { get; set; }
        #endregion

        #region Konstruktor
        internal SlotData(string aID, int aSortWeight, bool aAvailable)
            : base(aID, aSortWeight)
            => Available = aAvailable;
        #endregion
    }
}