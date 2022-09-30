using Exp.Util.Enumeration.Base;

namespace Exp.Util {
    public sealed class SortDirectionEnum : EnumerationBase {
        #region Properties / Felder
        #region Static
        public readonly static SortDirectionEnum None = new(nameof(None), " ");
        public readonly static SortDirectionEnum ASC = new(nameof(ASC), " ASC ");
        public readonly static SortDirectionEnum DESC = new(nameof(DESC), " DESC ");

        private static int mIndexCounter;
        #endregion

        #region Instance
        public string SqlKey { get; }
        #endregion
        #endregion

        #region Konstruktor
        public SortDirectionEnum(string aName, string aSqlKey)
            : base(mIndexCounter++, aName, string.Empty)
            => SqlKey = aSqlKey;
        #endregion

        #region Methoden
        public static List<SortDirectionEnum> Enumerate() {
            return EnumerateByIndex<SortDirectionEnum>(ASC);
        }

        #region Convert
        public static SortDirectionEnum Convert(int aIndex) {
            return Convert(aIndex, None);
        }

        public static SortDirectionEnum Convert(string aName) {
            return Convert(aName, None);
        }
        #endregion

        public static int Count() {
            return Count<SortDirectionEnum>();
        }

        public List<T> SortByIndex<T>(List<T> aDataList) where T : EnumerationBase {
            if (NameEquals(ASC)) {
                return aDataList.OrderBy(x => x.Index).ToList();
            } else if (NameEquals(DESC)) {
                return aDataList.OrderByDescending(x => x.Index).ToList();
            } else {
                return aDataList;
            }
        }

        public List<T> SortByName<T>(List<T> aDataList) where T : EnumerationBase {
            if (NameEquals(ASC)) {
                return aDataList.OrderBy(x => x.Name).ToList();
            } else if (NameEquals(DESC)) {
                return aDataList.OrderByDescending(x => x.Name).ToList();
            } else {
                return aDataList;
            }
        }
        #endregion
    }
}