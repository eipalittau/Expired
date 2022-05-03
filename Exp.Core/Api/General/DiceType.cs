namespace Exp.Api.General {
    public sealed class DiceType : ApiBase<Data.General.IDiceTypeData> {
        #region Properties / Felder
        public static DiceType Singleton { get; } = new();
        #endregion

        #region Konstruktor
        private DiceType() : base() { }
        #endregion

        #region Methoden
        public new void Remove(string aID) {
            base.Remove(aID);
        }

        public new void Clear() {
            base.Clear();
        }

        public new IList<Data.General.IDiceTypeData> List() {
            return base.List();
        }

        public new Data.General.IDiceTypeData Get(string aID) {
            return base.Get(aID);
        }

        public Data.General.IDiceTypeData Get(int aFaces) {
            Data.General.IDiceTypeData? lItem = Singleton.List()
                .Where(x => x.Faces == aFaces)
                .FirstOrDefault();

            if (lItem == null) {
                throw new Exp.Exception.DiceNotFoundException(aFaces);
            } else {
                return lItem;
            }

        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(Data.General.IDiceTypeData aItem) {
            if (aItem.Faces <= 1) {
                throw new Exp.Exception.BadArgumentException(nameof(aItem.Faces), aItem.Faces);
            } else {
                base.Add(aItem);
            }
        }
        #endregion
    }
}