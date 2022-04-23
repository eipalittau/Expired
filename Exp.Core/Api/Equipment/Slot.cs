namespace Exp.Api.Equipment {
    public sealed class Slot : ApiBase<Data.Equipment.ISlotData> {
        #region Properties / Felder
        public static Slot Singleton { get; } = new();
        #endregion

        #region Konstruktor
        private Slot() : base() { }
        #endregion
    }
}