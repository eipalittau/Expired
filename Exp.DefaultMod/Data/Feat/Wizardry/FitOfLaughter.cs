using Exp.Data.Feat.Wizardry;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Wizardry
{
    public sealed class FitOfLaughter : WizardryDataBase, IWizardryData {
        #region Konstruktor
        private FitOfLaughter()
            : base(nameof(FitOfLaughter), 600, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(LanguageEnum.Deutsch, "Lachanfall");
            Name.Set(LanguageEnum.English, "Fit of laughter");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new FitOfLaughter());
        }
        #endregion
    }
}