using Exp.Data.Feat.Wizardry;

namespace Exp.DefaultMod.Feat.Wizardry {
    public sealed class Chronos : WizardryDataBase, IWizardryData {
        #region Konstruktor
        private Chronos()
            : base(nameof(Chronos), 1600, Api.General.Tier.Singleton.Get(nameof(General.Tier.Three)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Free))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Chronos");
            Name.Set(Util.LanguageEnum.English, "Chronos");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Chronos());
        }
        #endregion
    }
}