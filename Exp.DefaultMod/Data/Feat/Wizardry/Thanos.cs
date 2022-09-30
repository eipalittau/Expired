using Exp.Data.Feat.Wizardry;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Wizardry
{
    public sealed class Thanos : WizardryDataBase, IWizardryData {
        #region Konstruktor
        private Thanos()
            : base(nameof(Thanos), 1800, Api.General.Tier.Singleton.Get(nameof(General.Tier.Three)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(LanguageEnum.Deutsch, "Thanos");
            Name.Set(LanguageEnum.English, "Thanos");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Thanos());
        }
        #endregion
    }
}