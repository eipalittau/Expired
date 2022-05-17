using Exp.Data.Feat.Wizardry;

namespace Exp.DefaultMod.Feat.Wizardry {
    public sealed class StinkyCloud : WizardryDataBase, IWizardryData {
        #region Konstruktor
        private StinkyCloud()
            : base(nameof(StinkyCloud), 200, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Stinkende Wolke");
            Name.Set(Util.LanguageEnum.English, "Stinky cloud");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new StinkyCloud());
        }
        #endregion
    }
}