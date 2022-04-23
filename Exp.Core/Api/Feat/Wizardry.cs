namespace Exp.Api.Feat {
    public sealed class Wizardry : ApiBase<Data.Feat.IWizardryData> {
        #region Properties / Felder
        public static Wizardry Singleton { get; } = new();
        #endregion

        #region Konstruktor
        private Wizardry() : base() { }
        #endregion
    }
}