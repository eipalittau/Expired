namespace Exp.Api.Equipment {
    public sealed class Effect : Base<Data.Equipment.EffectData> {
        #region Properties / Felder
        private static int mID = 0;
        private static readonly Effect mInstance = new();
        #endregion

        #region Konstruktor
        internal Effect() : base() {
            string lOrigin = base.GetOriginNameExecuting();

            Add(-1, -1, null);
            Add(-1, 0, null);
            Add(0, 0, null);
            Add(1, 0, null);
            Add(1, 1, null);
        }
        #endregion

        #region Methoden
        public static Effect Default() {
            return mInstance;
        }

        public void Add(int aPrimary, int aSecondary) {
            Add(aPrimary, aSecondary, base.GetOriginNameCaller());
        }

        private void Add(int aPrimary, int aSecondary, string? aOrigin) {
            int lID = mID + 1;
            string lName = $"Primary{aPrimary}_Secondary{aSecondary}";

            if (base.ItemExists(lID, lName)) {
                // Patrik: Throw Dublicate Exception
            } else {
                mID = lID;
                if (string.IsNullOrWhiteSpace(aOrigin)) {
                    aOrigin = base.GetOriginNameExecuting();
                }

                base.Add(new Data.Equipment.EffectData(lID, lName, string.Empty, (uint)base.Count() + 1, aOrigin, aPrimary, aSecondary));
            }
        }
        #endregion
    }
}