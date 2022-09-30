using Exp.Data.Feat.Wizardry;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Wizardry
{
    public sealed class StinkyCloud : WizardryDataBase, IWizardryData {
        #region Konstruktor
        private StinkyCloud()
            : base(nameof(StinkyCloud), 200, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(LanguageEnum.Deutsch, "Stinkende Wolke");
            Name.Set(LanguageEnum.English, "Stinky cloud");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new StinkyCloud());
        }
        #endregion
    }
}