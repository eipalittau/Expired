namespace Exp.Api.Equipment {
    public sealed class ItemQuality : Base<Data.Equipment.ItemQualityData> {
        #region Properties / Felder
        private static int mID = 0;
        #endregion

        #region Konstruktor
        internal ItemQuality() : base() {
            string lOrigin = base.GetOriginNameExecuting();

            Add("Rostig", "", true, false, Effect.Default().Get(1));
            Add("Schartig", "", true, false, Effect.Default().Get(2));
            Add("Normal", "", true, true, Effect.Default().Get(3));
            Add("Gehärtet", "", true, false, Effect.Default().Get(4));
            Add("Meisterhaft", "", false, false, Effect.Default().Get(5));
        }
        #endregion

        #region Methoden
        public void Add(int aID, string aName, string aDescription, bool aCanBeDestroyed, bool aIsDefault, Data.Equipment.EffectData aEffect) {
            Add(aID, aName, aDescription, (uint)base.Count() + 1, aCanBeDestroyed, aIsDefault, aEffect);
        }

        public void Add(int aID, string aName, string aDescription, uint aSortOrder, bool aCanBeDestroyed, bool aIsDefault, Data.Equipment.EffectData aEffect) {
            Add(aID, aName, aDescription, aSortOrder, base.GetOriginNameCaller(), aCanBeDestroyed, aIsDefault, aEffect);
        }

        private void Add(string aName, string aDescription, bool aCanBeDestroyed, bool aIsDefault, Data.Equipment.EffectData aEffect) {
            Add(++mID, aName, aDescription, (uint)base.Count() + 1, base.GetOriginNameExecuting(), aCanBeDestroyed, aIsDefault, aEffect);
        }

        private void Add(int aID, string aName, string aDescription, uint aSortOrder, string aOrigin, bool aCanBeDestroyed, bool aIsDefault, Data.Equipment.EffectData aEffect) {
            if (base.ItemExists(aID, aName)) {
                // Patrik: Throw Dublicate Exception
            } else {
                base.Add(new Data.Equipment.ItemQualityData(aID, aName, aDescription, aSortOrder, aOrigin, null, null, aCanBeDestroyed, aIsDefault, aEffect));
            }
        }
        #endregion
    }
}