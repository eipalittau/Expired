namespace Exp.Api.Equipment {
    public sealed class ItemType : ApiBase<Data.Equipment.IItemTypeData> {
        #region Properties / Felder
        public static ItemType Singleton { get; } = new();
        #endregion

        #region Konstruktor
        private ItemType() : base() { }
        #endregion
    }
}