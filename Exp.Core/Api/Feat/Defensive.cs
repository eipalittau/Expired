﻿namespace Exp.Api.Feat {
    public sealed class Defensive : ApiBase<Data.Feat.IDefensiveData> {
        #region Properties / Felder
        public static Defensive Singleton { get; } = new();
        #endregion

        #region Konstruktor
        internal Defensive() : base() { }
        #endregion

        #region Methoden
        public new void Remove(string aID) {
            base.Remove(aID);
        }

        public new void Clear() {
            base.Clear();
        }

        public new IList<Data.Feat.IDefensiveData> List() {
            return base.List();
        }

        public new Data.Feat.IDefensiveData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(Data.Feat.IDefensiveData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}