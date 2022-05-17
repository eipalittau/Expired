using Exp.Data.Feat.Wizardry;

namespace Exp.DefaultMod.Feat.Wizardry {
    public sealed class FitOfLaughter : WizardryDataBase, IWizardryData {
        #region Konstruktor
        private FitOfLaughter()
            : base(nameof(FitOfLaughter), 600, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Lachanfall");
            Name.Set(Util.LanguageEnum.English, "Fit of laughter");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new FitOfLaughter());
        }
        #endregion
    }
}