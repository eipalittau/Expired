namespace Exp.Api {
    public sealed class Main : IMain {
        #region Properties / Felder
        public static Main Singleton { get; } = new();
        #endregion

        public void Initialize() {
            Exp.Util.Localisation.AddResourceFile("Labeling.Labeling");
            Exp.Util.Localisation.Language = Exp.Util.LanguageEnum.Deutsch;
        }
    }
}