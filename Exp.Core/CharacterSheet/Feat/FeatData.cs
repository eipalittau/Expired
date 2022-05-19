using Exp.Data.Feat.Aura;
using Exp.Data.Feat.Defensive;
using Exp.Data.Feat.Offensive;
using Exp.Data.Feat.Wizardry;
using Exp.Data.Feat.Wonder;

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
            if (aTalent.GetType() == typeof(IAuraData)) {
                Aura.LevelUp((IAuraData)aTalent);

            } else if (aTalent.GetType() == typeof(IDefensiveData)) {
                Defensive.LevelUp((IDefensiveData)aTalent);

            } else if (aTalent.GetType() == typeof(IOffensiveData)) {
                Offensive.LevelUp((IOffensiveData)aTalent);

            } else if (aTalent.GetType() == typeof(IWizardryData)) {
                Wizardry.LevelUp((IWizardryData)aTalent);

            } else if (aTalent.GetType() == typeof(IWonderData)) {
                Wonder.LevelUp((IWonderData)aTalent);
            }
        }
        #endregion
    }
}