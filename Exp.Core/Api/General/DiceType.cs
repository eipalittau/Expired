namespace Exp.Api.General {
    public sealed class DiceType : ApiBase<Data.General.IDiceTypeDataBase> {
        #region Properties / Felder
        public static DiceType Singleton { get; } = new();
        #endregion

        #region Konstruktor
        private DiceType() : base() { }
        #endregion
    }
}