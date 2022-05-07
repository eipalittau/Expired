namespace Exp.Api.Player.Sheet {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class FeatData {
        #region Properties / Felder
        public OffensiveData Offensive { get; } = new();
        public DefensiveData Defensive { get; } = new();
        public WizardryData Wizardry { get; } = new();
        public WonderData Wonder { get; } = new();
        public AuraData Aura { get; } = new();
        public SmithingData Smithing { get; } = new();
        #endregion

        #region Konstruktor
        internal FeatData() { }
        #endregion
    }
}