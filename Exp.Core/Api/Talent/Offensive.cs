namespace Exp.Api.Talent {
    public sealed class Offensive : ApiBase<Data.Talent.OffensiveData> {
        #region Properties / Felder
        private static readonly Offensive mSingleton = new();
        #endregion

        #region Konstruktor
        internal Offensive() : base() {
            Add("Kampferprobt", 100, 1);
            Add("Steinwerfer", 200, 1, Data.General.ActionTypeEnum.Standard);
            Add("Eloquent beleidigen", 300, 1, Data.General.ActionTypeEnum.Standard);
            Add("Präziser Schuss", 400, 1);
            Add("Rundumschlag", 500, 1, Data.General.ActionTypeEnum.Standard);
            Add("CHARGE!", 600, 1, Data.General.ActionTypeEnum.Full);
            Add("Teamplayer", 700, 1);
            Add("Kampf mit zwei Waffen", 800, 1);
            Add("CHAAAARGE!!!", 900, 2, Data.General.ActionTypeEnum.Full);
            Add("Teamwork", 1000, 2, "Teamplayer");
            Add("Schnelles Mundwerk", 1100, 2, Data.General.ActionTypeEnum.Move, "Eloquent beleidigen");
            Add("Hinterhältig", 1200, 2, Data.General.ActionTypeEnum.Standard);
            Add("Schnellschuss", 1300, 2);
            Add("Anatomie", 1400, 2);
            Add("Besserer Kampf mit zwei Waffen", 1500, 2, "Kampf mit zwei Waffen");
            Add("Riposte", 1600, 2);
            Add("Dornenhaut", 1700, 2);
            Add("Cthulhu", 1800, 3);
            Add("Chaos", 1900, 3);
            Add("Hades", 2000, 3);
        }
        #endregion

        #region Methoden
        public static Offensive Singleton {
            get {
                return mSingleton;
            }
        }

        public void Add(string aID, int aSortWeight, int aTier) {
            base.Add(new Data.Talent.OffensiveData(aID, aSortWeight, aTier));
        }

        public void Add(string aID, int aSortWeight, int aTier, Data.General.ActionTypeEnum aActionType) {
            base.Add(new Data.Talent.OffensiveData(aID, aSortWeight, aTier, aActionType));
        }

        public void Add(string aID, int aSortWeight, int aTier, params Data.Talent.OffensiveData[] aPrerequisites) {
            base.Add(new Data.Talent.OffensiveData(aID, aSortWeight, aTier, aPrerequisites));
        }

        public void Add(string aID, int aSortWeight, int aTier, Data.General.ActionTypeEnum aActionType, params Data.Talent.OffensiveData[] aPrerequisites) {
            base.Add(new Data.Talent.OffensiveData(aID, aSortWeight, aTier, aActionType, aPrerequisites));
        }

        public void Add(string aID, int aSortWeight, int aTier, params string[] aPrerequisites) {
            base.Add(new Data.Talent.OffensiveData(aID, aSortWeight, aTier, base.Convert(aPrerequisites)));
        }

        public void Add(string aID, int aSortWeight, int aTier, Data.General.ActionTypeEnum aActionType, params string[] aPrerequisites) {
            base.Add(new Data.Talent.OffensiveData(aID, aSortWeight, aTier, aActionType, base.Convert(aPrerequisites)));
        }
        #endregion
    }
}