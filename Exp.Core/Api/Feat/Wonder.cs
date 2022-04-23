namespace Exp.Api.Feat {
    public sealed class Wonder : ApiBase<Data.Feat.IWonderData> {
        #region Properties / Felder
        public static Wonder Singleton { get; } = new();
        #endregion

        #region Konstruktor
        private Wonder() : base() { }
        #endregion
    }
}