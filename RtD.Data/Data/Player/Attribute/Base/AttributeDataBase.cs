namespace RtD.Data {
    public abstract class AttributeDataBase<T> {
        #region Properties / Felder
        public int Progress { get; private set; }
        public int MaxProgress {
            get {
                return (Tier1Count + Tier2Count + Tier3Count);
            }
        }
        public int Tier1Count {
            get {
                return 5;
            }
        }
        public int Tier2Count {
            get {
                return 4;
            }
        }
        public int Tier3Count {
            get {
                return 1;
            }
        }
        public List<T> TalenentList { get; } = new List<T>();
        #endregion

        #region Konstruktor
        protected AttributeDataBase() { }
        #endregion

        #region Methoden
        protected int Increase(T aTalent) {
            if (Progress == MaxProgress) {
                throw new Exception("MaxLevel reached"); // Patrik: Exception wenn Maxlevel überschritten wird.
            }
            if (aTalent == null) {
                throw new Exception(""); // Patrik: Exception
            }
            if (TalenentList.Contains(aTalent)) {
                throw new Exception(""); // Patrik: Exception
            }

            Progress++;
            TalenentList.Add(aTalent);

            if (Progress <= Tier1Count) {
                return Progress;
            } else if (Progress <= Tier1Count + Tier2Count) {
                return Tier1Count + (Progress - Tier1Count) * 2;
            } else {
                return Tier1Count + Tier2Count * 2 + (Progress - Tier1Count - Tier2Count) * 3;
            }
        }
        #endregion
    }
}