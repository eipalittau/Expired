namespace Exp.Api.Feat {
    public sealed class Defensive : ApiBase<Data.Feat.IDefensiveData> {
        #region Properties / Felder
        public static Defensive Singleton { get; } = new();
        #endregion

        #region Konstruktor
        internal Defensive() : base() { }
        #endregion
    }
}