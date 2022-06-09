using Exp.Data.Misc.Recollection;
using System.ComponentModel;

namespace Exp.Core.Sheet {
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class RecollectionData : SheetBase {
        #region Properties / Felder
        private readonly List<IRecollectionData> mDataList = new();
        #endregion

        #region Konstruktor
        internal RecollectionData(CharacterSheet aMain)
            : base(aMain) { }
        #endregion

        #region Methoden
        internal new void OnNewDay() {
            Remember();
        }

        internal void Remember() {
            IRecollectionData lRecollection = Api.Misc.Recollection.Singleton.GetRandom();

            if (mDataList.Contains(lRecollection)) {
                Main.RaiseNewRecollection(new(true, lRecollection));
            } else {
                mDataList.Add(lRecollection);
                Main.RaiseNewRecollection(new(false, lRecollection));
            }
        }

        internal int Count() {
            return mDataList.Count;
        }

        internal IRecollectionData? Get(int aIndex) {
            if (aIndex < 0 || aIndex > mDataList.Count) {
                Util.ExceptionHandler.Add(new Exception.OutOfRangeException(nameof(aIndex), aIndex, 0, mDataList.Count));
                return null;
            } else {
                return mDataList[aIndex];
            }
        }

        internal IList<IRecollectionData> Enumerate() {
            return mDataList.AsReadOnly();
        }
        #endregion
    }
}