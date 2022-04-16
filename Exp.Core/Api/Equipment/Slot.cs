namespace Exp.Api.Equipment {
    public sealed class Slot : ApiBase<Data.Equipment.SlotData> {
        #region Properties / Felder
        private static readonly Slot mSingleton = new();
        #endregion

        #region Konstruktor
        internal Slot() : base() {
            Add("Körper", true, 100);
            Add("Füsse", false, 200);
            Add("Haupthand", true, 300);
            Add("Nebenhand", true, 400);
            Add("Ringfinger links", true, 500);
            Add("Ringfinger rechts", true, 600);
            Add("Handgelenk links", true, 700);
            Add("Handgelenk rechts", true, 800);
            Add("Hals", true, 900);
            Add("Schultern", true, 1000);
            Add("Kopf", true, 1200);
            Add("Tasche", true, 1300);
        }
        #endregion

        #region Methoden
        public static Slot Singleton {
            get {
                return mSingleton;
            }
        }

        private void Add(string aID, bool aAvailable, int aSortWeight = 0) {
            base.Add(new Data.Equipment.SlotData(aID, aSortWeight, aAvailable));
        }
        #endregion
    }
}