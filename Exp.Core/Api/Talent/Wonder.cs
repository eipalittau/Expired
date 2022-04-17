namespace Exp.Api.Talent {
    public sealed class Wonder : ApiBase<Data.Talent.WonderData> {
        #region Properties / Felder
        private static readonly Wonder mSingleton = new();
        #endregion

        #region Konstruktor
        internal Wonder() : base() {
            Add("Eisrüstung", 100, 1);
            Add("Magische Waffe", 200, 1, Data.General.ActionTypeEnum.Standard);
            Add("Wunderpuppe", 300, 1, Data.General.ActionTypeEnum.Standard);
            Add("Eiskaltes Händchen", 400, 1, Data.General.ActionTypeEnum.Standard); //Englische Übersetzung aus "Addams Family"
            Add("Hast", 500, 1, Data.General.ActionTypeEnum.Standard);
            Add("Schmieren", 600, 1, Data.General.ActionTypeEnum.Standard);
            Add("Wunderfokus", 700, 1);
            Add("Wundermacht", 800, 1);
            Add("Diamantrüstung", 900, 2);
            Add("Zielsichere Waffe", 1000, 2);
            Add("Negative Energie Kanalisieren", 1100, 2, Data.General.ActionTypeEnum.Standard);
            Add("Horde", 1200, 2, Data.General.ActionTypeEnum.Standard);
            Add("BRAINZZZZ!", 1300, 2, Data.General.ActionTypeEnum.Full);
            Add("Wunderfokus++", 1400, 2, "Wunderfokus");
            Add("Wundermacht++", 1500, 2, "Wundermacht");
            Add("Tartaros", 1600, 3);
            Add("Nyx", 1700, 3);
            Add("Styx", 1800, 3, Data.General.ActionTypeEnum.Standard);

    }
    #endregion

    #region Methoden
    public static Wonder Singleton {
            get {
                return mSingleton;
            }
        }

        public void Add(string aID, int aSortWeight, int aTier) {
            base.Add(new Data.Talent.WonderData(aID, aSortWeight, aTier));
        }

        public void Add(string aID, int aSortWeight, int aTier, Data.General.ActionTypeEnum aActionType) {
            base.Add(new Data.Talent.WonderData(aID, aSortWeight, aTier, aActionType));
        }

        public void Add(string aID, int aSortWeight, int aTier, params Data.Talent.WonderData[] aPrerequisites) {
            base.Add(new Data.Talent.WonderData(aID, aSortWeight, aTier, aPrerequisites));
        }

        public void Add(string aID, int aSortWeight, int aTier, Data.General.ActionTypeEnum aActionType, params Data.Talent.WonderData[] aPrerequisites) {
            base.Add(new Data.Talent.WonderData(aID, aSortWeight, aTier, aActionType, aPrerequisites));
        }

        public void Add(string aID, int aSortWeight, int aTier, params string[] aPrerequisites) {
            base.Add(new Data.Talent.WonderData(aID, aSortWeight, aTier, base.Convert(aPrerequisites)));
        }

        public void Add(string aID, int aSortWeight, int aTier, Data.General.ActionTypeEnum aActionType, params string[] aPrerequisites) {
            base.Add(new Data.Talent.WonderData(aID, aSortWeight, aTier, aActionType, base.Convert(aPrerequisites)));
        }
        #endregion
    }
}