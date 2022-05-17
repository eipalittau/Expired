using Exp.Data.Feat.Wizardry;

namespace Exp.DefaultMod.Feat.Wizardry {
    public sealed class Dionysos : WizardryDataBase, IWizardryData {
        #region Konstruktor
        private Dionysos()
            : base(nameof(Dionysos), 1700, Api.General.Tier.Singleton.Get(nameof(General.Tier.Three)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Dionysos");
            Name.Set(Util.LanguageEnum.English, "Dionysos");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Dionysos());
        }
        #endregion
    }
}