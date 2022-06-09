using Exp.Api.General;
using Exp.Data.Feat.Aura;
using Exp.Data.Feat.Defensive;
using Exp.Data.Feat.Offensive;
using Exp.Data.Feat.Wizardry;
using Exp.Data.Feat.Wonder;
using System.ComponentModel;

namespace Exp.Core.Sheet {
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class FeatData {
        #region Properties / Felder
        public OffensiveData Offensive { get; init; }
        public DefensiveData Defensive { get; init; }
        public WizardryData Wizardry { get; init; }
        public WonderData Wonder { get; init; }
        public AuraData Aura { get; init; }
        public int AvailableFeatPoints { get; private set; }
        #endregion

        #region Konstruktor
        internal FeatData(int aMaxLevel) {
            Aura = new(aMaxLevel);
            Defensive = new(aMaxLevel);
            Offensive = new(aMaxLevel);
            Wizardry = new(aMaxLevel);
            Wonder = new(aMaxLevel);
        }

        #endregion

        #region Methoden
        internal void SetFeatPoints() {
            if (Api.Player.LevelUp.Singleton.Contains(TargetEffectEnum.FeatPoints)) {
                AvailableFeatPoints = Api.Player.LevelUp.Singleton.Get(TargetEffectEnum.FeatPoints).Base.Value;
            }
        }

        internal bool LevelUp(Data.Feat.IFeatDataBase aFeat) {
            bool lResult = false;

            if (AvailableFeatPoints > 0) {
                if (aFeat.GetType() == typeof(IAuraData)) {
                    lResult = Aura.LevelUp((IAuraData)aFeat);

                } else if (aFeat.GetType() == typeof(IDefensiveData)) {
                    lResult = Defensive.LevelUp((IDefensiveData)aFeat);

                } else if (aFeat.GetType() == typeof(IOffensiveData)) {
                    lResult = Offensive.LevelUp((IOffensiveData)aFeat);

                } else if (aFeat.GetType() == typeof(IWizardryData)) {
                    lResult = Wizardry.LevelUp((IWizardryData)aFeat);

                } else if (aFeat.GetType() == typeof(IWonderData)) {
                    lResult = Wonder.LevelUp((IWonderData)aFeat);
                }

                if (lResult) {
                    AvailableFeatPoints--;
                }
            }

            return lResult;
        }
        #endregion
    }
}