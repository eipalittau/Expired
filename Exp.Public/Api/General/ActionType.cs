using Exp.Data.General.ActionType;

namespace Exp.Api.General {
    public sealed class ActionType : ApiBase<IActionTypeData> {
        #region Properties / Felder
        public static ActionType Singleton { get; } = new();

        public double Limit { get; init; } = 2.5;
        public double RemainingActions { get; private set; }
        #endregion

        #region Konstruktor
        private ActionType() : base() {
            NewRound();
        }
        #endregion

        #region Methoden
        internal new void Remove(string aID) {
            base.Remove(aID);
        }

        internal new void Clear() {
            base.Clear();
        }

        public new IList<IActionTypeData> Enumerate() {
            return base.Enumerate();
        }

        public new IActionTypeData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        internal new void Add(IActionTypeData aItem) {
            base.Add(aItem);
        }

        public void NewRound() {
            RemainingActions = Limit;
        }

        public bool ExecuteAction(IActionTypeData aAction) {
            if (RemainingActions - aAction.Weight < 0) {
                return false;
            } 
            
            RemainingActions -= aAction.Weight;
            
            return true;
        }
        #endregion
    }
}