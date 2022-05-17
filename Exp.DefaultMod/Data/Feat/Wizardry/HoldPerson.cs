using Exp.Data.Feat.Wizardry;

namespace Exp.DefaultMod.Feat.Wizardry {
    public sealed class HoldPerson : WizardryDataBase, IWizardryData {
        #region Konstruktor
        private HoldPerson()
            : base(nameof(HoldPerson), 1100, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Person festhalten");
            Name.Set(Util.LanguageEnum.English, "Hold person");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new HoldPerson());
        }
        #endregion
    }
}