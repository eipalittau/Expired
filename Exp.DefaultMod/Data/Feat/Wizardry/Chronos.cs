using Exp.Data.Feat.Wizardry;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Wizardry
{
    public sealed class Chronos : WizardryDataBase, IWizardryData {
        #region Konstruktor
        private Chronos()
            : base(nameof(Chronos), 1600, Api.General.Tier.Singleton.Get(nameof(General.Tier.Three)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Free))) {
            Name.Set(LanguageEnum.Deutsch, "Chronos");
            Name.Set(LanguageEnum.English, "Chronos");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Chronos());
        }
        #endregion
    }
}