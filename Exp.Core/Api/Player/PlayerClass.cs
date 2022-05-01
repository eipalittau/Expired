namespace Exp.Api.Player {
    public sealed class PlayerClass : ApiBase<Data.Player.IPlayerClassData> {
        #region Properties / Felder
        public static PlayerClass Singleton { get; } = new();
        #endregion

        #region Konstruktor
        private PlayerClass() : base() { }
        #endregion

        #region Methoden
        public new void Remove(string aID) {
            base.Remove(aID);
        }

        public new void Clear() {
            base.Clear();
        }

        public new IList<Data.Player.IPlayerClassData> List() {
            return base.List();
        }

        public new Data.Player.IPlayerClassData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(Data.Player.IPlayerClassData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}