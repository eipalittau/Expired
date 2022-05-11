namespace Exp.Api.Player.Sheet {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class FeatData {
        #region Properties / Felder
        public OffensiveData Offensive { get; } = new();
        public DefensiveData Defensive { get; } = new();
        public WizardryData Wizardry { get; } = new();
        public WonderData Wonder { get; } = new();
        public AuraData Aura { get; } = new();
        #endregion

        #region Konstruktor
        internal FeatData() { }
        #endregion

        #region Methoden
        internal void LevelUp(Data.Feat.IFeatDataBase aTalent) {
            if (aTalent.GetType() == typeof(Data.Feat.IAuraData)) {
                Aura.LevelUp((Data.Feat.IAuraData)aTalent);

            } else if (aTalent.GetType() == typeof(Data.Feat.IDefensiveData)) {
                Defensive.LevelUp((Data.Feat.IDefensiveData)aTalent);

            } else if (aTalent.GetType() == typeof(Data.Feat.IOffensiveData)) {
                Offensive.LevelUp((Data.Feat.IOffensiveData)aTalent);

            } else if (aTalent.GetType() == typeof(Data.Feat.IWizardryData)) {
                Wizardry.LevelUp((Data.Feat.IWizardryData)aTalent);

            } else if (aTalent.GetType() == typeof(Data.Feat.IWonderData)) {
                Wonder.LevelUp((Data.Feat.IWonderData)aTalent);
            }
        }
        #endregion
    }
}