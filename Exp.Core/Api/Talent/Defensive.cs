namespace Exp.Api.Talent {
    public sealed class Defensive : ApiBase<Data.Talent.DefensiveData> {
        #region Properties / Felder
        private static readonly Defensive mSingleton = new();
        #endregion

        #region Konstruktor
        internal Defensive() : base() {
            Add("Schubsen", 100, 1, Data.General.ActionTypeEnum.Free);
            Add("Zäh", 200, 1);
            Add("Katzenreflex", 300, 1);
            Add("Gefahreninstinkt", 400,1);
            Add("Ausweichen", 500, 1);
            Add("Agil", 600, 1);
            Add("Teamplayer", 700, 1);
            Add("Anpinnen", 800, 1);
            Add("Schattenhaft", 900, 2);
            Add("Zweiter Wind", 1000, 2, Data.General.ActionTypeEnum.Standard);
            Add("Teamwork", 1100, 2, "Teamplayer");
            Add("Steinhaut", 1200, 2);
            Add("Verbessertes Ausweichen", 1300, 2, "Ausweichen");
            Add("Der gestiefelte Kater", 1400, 2);
            Add("RoadRunner", 1500, 2);
            Add("Hermes", 1600, 3);
            Add("Hephaistos", 1700, 3);
            Add("Zeus", 1800, 3);
        }
        #endregion

        #region Methoden
        public static Defensive Singleton {
            get {
                return mSingleton;
            }
        }

        public void Add(string aID, int aSortWeight, int aTier) {
            base.Add(new Data.Talent.DefensiveData(aID, aSortWeight, aTier));
        }

        public void Add(string aID, int aSortWeight, int aTier, Data.General.ActionTypeEnum aActionType) {
            base.Add(new Data.Talent.DefensiveData(aID, aSortWeight, aTier, aActionType));
        }

        public void Add(string aID, int aSortWeight, int aTier, params Data.Talent.DefensiveData[] aPrerequisites) {
            base.Add(new Data.Talent.DefensiveData(aID, aSortWeight, aTier, aPrerequisites));
        }

        public void Add(string aID, int aSortWeight, int aTier, Data.General.ActionTypeEnum aActionType, params Data.Talent.DefensiveData[] aPrerequisites) {
            base.Add(new Data.Talent.DefensiveData(aID, aSortWeight, aTier, aActionType, aPrerequisites));
        }

        public void Add(string aID, int aSortWeight, int aTier, params string[] aPrerequisites) {
            base.Add(new Data.Talent.DefensiveData(aID, aSortWeight, aTier, base.Convert(aPrerequisites)));
        }

        public void Add(string aID, int aSortWeight, int aTier, Data.General.ActionTypeEnum aActionType, params string[] aPrerequisites) {
            base.Add(new Data.Talent.DefensiveData(aID, aSortWeight, aTier, aActionType, base.Convert(aPrerequisites)));
        }
        #endregion
    }
}