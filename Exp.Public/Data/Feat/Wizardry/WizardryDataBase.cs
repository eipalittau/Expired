using Exp.Data.General.ActionType;
using Exp.Data.General.Tier;
using System.Text;

namespace Exp.Data.Feat.Wizardry {
    public abstract class WizardryDataBase : FeatDataBase<IWizardryData> {
        #region Properties / Felder
        /// <summary>Ist diese Fähigkeit eine Aktion? (Standard, Bewegung, etc.)</summary>
        public IActionTypeData? ActionType { get; set; }
        #endregion

        #region Konstruktor
        protected WizardryDataBase(string aID, int aSortWeight, ITierData aTier, IActionTypeData aActionType, params IWizardryData[] aPrerequisites)
            : this(aID, aSortWeight, aTier, aPrerequisites)
            => ActionType = aActionType;

        protected WizardryDataBase(string aID, int aSortWeight, ITierData aTier, params IWizardryData[] aPrerequisites)
            : base(aID, aSortWeight, aTier, aPrerequisites) { }
        #endregion

        #region Methoden
        public new string GetFullDescription() {
            StringBuilder lDescription = base.GetFullDescription();

            if (ActionType != null) {
                lDescription.AppendLine(string.Empty);
                lDescription.AppendLine("Action-Type:");
                lDescription.AppendLine($"{ActionType.GetName()} ({ActionType.GetLoreDescription()})");
            }

            if (PrerequisiteList.Count > 0) {
                lDescription.AppendLine(string.Empty);
                PrerequisiteList.ForEach(x => lDescription.AppendLine($"- {x.GetName()}"));
            }

            return lDescription.ToString();
        }

        protected static void AddInstance(IWizardryData aInstance) {
            Api.Feat.Wizardry.Singleton.Add(aInstance);
        }
        #endregion
    }
}