namespace RtD.Data {
    public abstract class SkillDataBase {
        #region Properties / Felder
        public int Progress { get; private set; }
        public int MaxProgress {
            get {
                return (Tier1Count + Tier2Count + Tier3Count);
            }
        }
        public int Tier1Count {
            get {
                return 2;
            }
        }
        public int Tier2Count {
            get {
                return 2;
            }
        }
        public int Tier3Count {
            get {
                return 1;
            }
        }
        public int Value { get; private set; }
        #endregion

        #region Konstruktor
        protected SkillDataBase() { }
        #endregion

        #region Methoden
        protected void Increase() {
            if (Progress == MaxProgress) {
                throw new Exception("MaxLevel reached"); // Patrik: Exception wenn Maxlevel überschritten wird.
            }

            Progress++;

            if (Progress <= Tier1Count) {
                Value = Progress;
            } else if (Progress <= Tier1Count + Tier2Count) {
                Value = Tier1Count + (Progress - Tier1Count) * 2;
            } else {
                Value = Tier1Count + Tier2Count * 2 + (Progress - Tier1Count - Tier2Count) * 3;
            }
        }
        #endregion
    }
}