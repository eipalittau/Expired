namespace Exp.Api.General {
    public sealed class ActionType : ApiBase<Data.General.IActionTypeData> {
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

        public new IList<Data.General.IActionTypeData> List() {
            return base.List();
        }

        public new Data.General.IActionTypeData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        internal new void Add(Data.General.IActionTypeData aItem) {
            base.Add(aItem);
        }

        public void NewRound() {
            RemainingActions = Limit;
        }

        public bool ExecuteAction(Data.General.IActionTypeData aAction) {
            if (RemainingActions - aAction.Weight < 0) {
                return false;
            } 
            
            RemainingActions -= aAction.Weight;
            
            return true;
        }
        #endregion
    }
}