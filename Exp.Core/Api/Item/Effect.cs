namespace Exp.Api.Item {
    public sealed class Effect : ApiBase<Data.Item.IEffectData> {
        #region Properties / Felder
        public static Effect Singleton { get; } = new();
        #endregion

        #region Konstruktor
        private Effect() : base() { }
        #endregion

        #region Methoden
        public new void Remove(string aID) {
            base.Remove(aID);
        }

        public new void Clear() {
            base.Clear();
        }

        public new IList<Data.Equipment.IEffectData> List() {
            return base.List();
        }

        public new Data.Equipment.IEffectData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(Data.Equipment.IEffectData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}