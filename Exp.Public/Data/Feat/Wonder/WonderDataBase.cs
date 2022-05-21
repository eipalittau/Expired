using Exp.Data.General.ActionType;
using Exp.Data.General.Tier;
using System.Text;

namespace Exp.Data.Feat.Wonder {
    public abstract class WonderDataBase : FeatDataBase<IWonderData> {
        #region Properties / Felder
        /// <summary>Ist diese Fähigkeit eine Aktion? (Standard, Bewegung, etc.)</summary>
        public IActionTypeData? ActionType { get; set; }
        #endregion

        #region Konstruktor
        protected WonderDataBase(string aID, int aSortWeight, ITierData aTier, IActionTypeData aActionType, params IWonderData[] aPrerequisites)
            : base(aID, aSortWeight, aTier, aPrerequisites)
            => ActionType = aActionType;

        protected WonderDataBase(string aID, int aSortWeight, ITierData aTier, params IWonderData[] aPrerequisites)
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

        protected static void AddInstance(IWonderData aInstance) {
            Api.Feat.Wonder.Singleton.Add(aInstance);
        }
        #endregion
    }
}