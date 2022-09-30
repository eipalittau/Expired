using Exp.Data.Feat.Wizardry;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Wizardry
{
    public sealed class Dionysos : WizardryDataBase, IWizardryData {
        #region Konstruktor
        private Dionysos()
            : base(nameof(Dionysos), 1700, Api.General.Tier.Singleton.Get(nameof(General.Tier.Three)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(LanguageEnum.Deutsch, "Dionysos");
            Name.Set(LanguageEnum.English, "Dionysos");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Dionysos());
        }
        #endregion
    }
}