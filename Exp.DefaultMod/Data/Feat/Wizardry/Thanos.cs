namespace Exp.DefaultMod.Feat.Wizardry {
    public sealed class Thanos : Exp.Data.Feat.WizardryDataBase, Exp.Data.Feat.IWizardryData {
        #region Konstruktor
        private Thanos()
            : base(nameof(Thanos), 1800, Api.General.Tier.Singleton.Get(nameof(General.Tier.Three)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Thanos");
            Name.Set(Util.LanguageEnum.English, "Thanos");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Thanos());
        }
        #endregion
    }
}