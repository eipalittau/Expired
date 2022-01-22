namespace RtD.Data {
    public abstract class TalentEnumBase<T> : Enumerations.EnumerationBase {
        #region Properties / Felder
        public int Tier { get; }
        public ActionTypeEnum? ActionType { get; }
        public T[]? Prerequisite { get; }
        #endregion

        #region Konstruktor
        public TalentEnumBase(byte aID, string aName, string aDescription, int aTier, ActionTypeEnum? aActionType, params T[]? aPrerequisite)
            : base(aID, aName, aDescription)
            => (Tier, ActionType, Prerequisite) = (aTier, aActionType, aPrerequisite);
        #endregion
    }
}