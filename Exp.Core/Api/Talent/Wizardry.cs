namespace Exp.Api.Talent {
    public sealed class Wizardry : ApiBase<Data.Talent.WizardryData> {
        #region Properties / Felder
        private static readonly Wizardry mSingleton = new();
        #endregion

        #region Konstruktor
        internal Wizardry() : base() {
            Add("Magische Welle", 100,  1, Data.General.ActionTypeEnum.Standard);
            Add("Stinkende Wolke", 200, 1, Data.General.ActionTypeEnum.Standard);
            Add("Spiegelbild", 300, 1, Data.General.ActionTypeEnum.Standard);
            Add("Schild", 400, 1, Data.General.ActionTypeEnum.Free);
            Add("Schrek", 500, 1, Data.General.ActionTypeEnum.Standard);
            Add("Lachanfall", 600, 1, Data.General.ActionTypeEnum.Standard);
            Add("Zauberfokus", 700, 1);
            Add("Zaubermacht", 800, 1);
            Add("Eiszapfen", 900, 2, Data.General.ActionTypeEnum.Move);
            Add("Feuerball", 1000, 2, Data.General.ActionTypeEnum.Standard);
            Add("Person Festhalten", 1100, 2, Data.General.ActionTypeEnum.Standard);
            Add("Metamagie", 1200, 2);
            Add("Verbesserte Magische Welle", 1300, 2, Data.General.ActionTypeEnum.Standard, "Magische Welle");
            Add("Zauberfokus++", 1400, 2, "Zauberfokus");
            Add("Zaubermacht++", 1500, 2, "Zaubermacht");
            Add("Chronos", 1600, 3, Data.General.ActionTypeEnum.Free);
            Add("Dionysos", 1700, 3, Data.General.ActionTypeEnum.Standard);
            Add("Thanos", 1800, 3, Data.General.ActionTypeEnum.Standard);
        }
        #endregion

        #region Methoden
        public static Wizardry Singleton {
            get {
                return mSingleton;
            }
        }

        public void Add(string aID, int aSortWeight, int aTier) {
            base.Add(new Data.Talent.WizardryData(aID, aSortWeight, aTier));
        }

        public void Add(string aID, int aSortWeight, int aTier, Data.General.ActionTypeEnum aActionType) {
            base.Add(new Data.Talent.WizardryData(aID, aSortWeight, aTier, aActionType));
        }

        public void Add(string aID, int aSortWeight, int aTier, params Data.Talent.WizardryData[] aPrerequisites) {
            base.Add(new Data.Talent.WizardryData(aID, aSortWeight, aTier, aPrerequisites));
        }

        public void Add(string aID, int aSortWeight, int aTier, Data.General.ActionTypeEnum aActionType, params Data.Talent.WizardryData[] aPrerequisites) {
            base.Add(new Data.Talent.WizardryData(aID, aSortWeight, aTier, aActionType, aPrerequisites));
        }

        public void Add(string aID, int aSortWeight, int aTier, params string[] aPrerequisites) {
            base.Add(new Data.Talent.WizardryData(aID, aSortWeight, aTier, base.Convert(aPrerequisites)));
        }

        public void Add(string aID, int aSortWeight, int aTier, Data.General.ActionTypeEnum aActionType, params string[] aPrerequisites) {
            base.Add(new Data.Talent.WizardryData(aID, aSortWeight, aTier, aActionType, base.Convert(aPrerequisites)));
        }
        #endregion
    }
}