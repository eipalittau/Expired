using Exp.Data.General.DamageType;

namespace Exp.Api.General {
    public sealed class DamageType : ApiBase<IDamageTypeData> {
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

        public new IList<IDamageTypeData> Enumerate() {
            return base.Enumerate();
        }

        public new IDamageTypeData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        internal new void Add(IDamageTypeData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}
