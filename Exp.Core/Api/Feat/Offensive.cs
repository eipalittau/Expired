namespace Exp.Api.Feat {
    public sealed class Offensive : ApiBase<Data.Feat.IOffensiveData> {
        #region Properties / Felder
        public static Offensive Singleton { get; } = new();
        #endregion

        #region Konstruktor
        private Offensive() : base() { }
        #endregion
    }
}