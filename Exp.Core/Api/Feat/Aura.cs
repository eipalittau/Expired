namespace Exp.Api.Feat {
    public sealed class Aura : ApiBase<Data.Feat.IAuraData> {
        #region Properties / Felder
        public static Aura Singleton { get; } = new();
        #endregion

        #region Konstruktor
        private Aura() : base() { }
        #endregion
    }
}