using Exp.Data.General.DiceType;
using Exp.Util;
using Exp.Util.Extension;

namespace Exp.Api.General {
    public sealed class DiceType : ApiBase<IDiceTypeData> {
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

        public new IList<IDiceTypeData> Enumerate() {
            return base.Enumerate();
        }

        public new IDiceTypeData Get(string aID) {
            return base.Get(aID);
        }

        public new IDiceTypeData Get(int aFaces) {
            IDiceTypeData? lItem = Singleton.Enumerate()
                .Where(x => x.Faces == aFaces)
                .FirstOrDefault();

            if (lItem == null) {
                throw new Exception.DiceNotFoundException(aFaces);
            } else {
                return lItem;
            }

        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(IDiceTypeData aItem) {
            if (aItem.Faces <= 1 && !aItem.IsDefaultObject()) {
                ExceptionHandler.Add(new Exception.BadArgumentException(nameof(aItem.Faces), aItem.Faces));
            } else {
                base.Add(aItem);
            }
        }
        #endregion
    }
}