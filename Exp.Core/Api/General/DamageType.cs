namespace Exp.Api.General {
    public sealed class DamageType : ApiBase<Data.General.IDamageTypeData> {
        #region Properties / Felder
        public static DamageType Singleton { get; } = new();
        #endregion

        #region Konstruktor
        private DamageType() : base() { }
        #endregion

        #region Methoden
        internal new void Remove(string aID) {
            base.Remove(aID);
        }

        internal new void Clear() {
            base.Clear();
        }

        public new IList<Data.General.IDamageTypeData> List() {
            return base.List();
        }

        public new Data.General.IDamageTypeData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        internal new void Add(Data.General.IDamageTypeData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}
