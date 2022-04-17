namespace Exp.Api.Talent {
    public sealed class Aura : ApiBase<Data.Talent.AuraData> {
        #region Properties / Felder
        private static readonly Aura mSingleton = new();
        #endregion

        #region Konstruktor
        internal Aura() : base() {
            Add("Aura des Fechters", 100, 1);
            Add("Aura der Macht", 200, 1);
            Add("Aura der Verteidigung", 300, 1);
            Add("Aura der Reflexe", 400, 1);
            Add("Aura des Willens", 500, 1);
            Add("Aura des Zorns", 600, 1, "Aura des Fechters", "Aura der Macht");
            Add("Fokus", 700, 1);
            Add("Verstärkte Aura", 800, 1);
            Add("Blähungen", 900, 1);
            Add("Gambit der gebrochenen Flügel", 1000, 1, Data.General.ActionTypeEnum.Free);
            Add("Geschickt", 1100, 1);
            Add("Koordiniert", 1200, 1);
            Add("Love and Pieces", 1300, 1, Data.General.ActionTypeEnum.Move);
            Add("Sadist", 1400, 1);
            Add("Masochist", 1500, 1);
            Add("Perfektion", 1600, 2);
            Add("Interdisziplinär", 1700, 2);
            Add("Bannerträger", 1800, 2);
        }
        #endregion

        #region Methoden
        public static Aura Singleton {
            get {
                return mSingleton;
            }
        }

        public void Add(string aID, int aSortWeight, int aTier) {
            base.Add(new Data.Talent.AuraData(aID, aSortWeight, aTier));
        }

        public void Add(string aID, int aSortWeight, int aTier, Data.General.ActionTypeEnum aActionType) {
            base.Add(new Data.Talent.AuraData(aID, aSortWeight, aTier, aActionType));
        }

        public void Add(string aID, int aSortWeight, int aTier, params Data.Talent.AuraData[] aPrerequisites) {
            base.Add(new Data.Talent.AuraData(aID, aSortWeight, aTier, aPrerequisites));
        }

        public void Add(string aID, int aSortWeight, int aTier, Data.General.ActionTypeEnum aActionType, params Data.Talent.AuraData[] aPrerequisites) {
            base.Add(new Data.Talent.AuraData(aID, aSortWeight, aTier, aActionType, aPrerequisites));
        }

        public void Add(string aID, int aSortWeight, int aTier, params string[] aPrerequisites) {
            base.Add(new Data.Talent.AuraData(aID, aSortWeight, aTier, base.Convert(aPrerequisites)));
        }

        public void Add(string aID, int aSortWeight, int aTier, Data.General.ActionTypeEnum aActionType, params string[] aPrerequisites) {
            base.Add(new Data.Talent.AuraData(aID, aSortWeight, aTier, aActionType, base.Convert(aPrerequisites)));
        }
        #endregion
    }
}