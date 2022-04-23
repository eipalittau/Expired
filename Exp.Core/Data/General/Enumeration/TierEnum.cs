namespace Exp.Data.General {
    public sealed class TierEnum : Util.EnumerationBase {
        #region Properties / Felder
        #region Static
        internal static TierEnum None = new(0, 0);
        public static TierEnum One = new(1, 1);
        public static TierEnum Two = new(2, 2);
        public static TierEnum Three = new(3, 3);
        #endregion

        #region Instance
        public int Tier { get; }
        #endregion
        #endregion

        #region Konstruktor
        private TierEnum(int aID, int aTier)
            : base(aID)
            => Tier = aTier;
        #endregion

        #region Methoden
        public static IList<TierEnum> Enumerate() {
            return Util.EnumerationBase.Enumerate<TierEnum>(Util.Enumeration.SortDirectionEnum.ASC);
        }

        public static int Count() {
            return Util.EnumerationBase.Count<TierEnum>();
        }

        public static TierEnum Convert(int aID) {
            return Util.EnumerationBase.Convert<TierEnum>(aID, None);
        }

        public static TierEnum Convert(string aName, Util.LanguageEnum aLanguage) {
            return Util.EnumerationBase.Convert(aName, aLanguage, None);
        }
        #endregion
    }
}