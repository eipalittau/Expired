namespace Exp.Data.Talent {
    public abstract class TalentDataBase<T> : DataBase {
        #region Properties / Felder
        public int Tier { get; }
        public General.ActionTypeEnum? ActionType { get; }
        public List<T> Prerequisite { get; }
        #endregion

        #region Konstruktor
        protected TalentDataBase(string aID, int aSortWeight, int aTier, General.ActionTypeEnum? aActionType, params T[] aPrerequisites)
            : base(aID, aSortWeight) {
            Tier = aTier;
            ActionType = aActionType;

            if (aPrerequisites == null || aPrerequisites.Length == 0) {
                Prerequisite = new List<T>();
            } else {
                Prerequisite = aPrerequisites.ToList();
            }
        }
        #endregion
    }
}