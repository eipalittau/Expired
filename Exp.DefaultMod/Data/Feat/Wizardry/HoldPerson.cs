using Exp.Data.Feat.Wizardry;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Wizardry
{
    public sealed class HoldPerson : WizardryDataBase, IWizardryData {
        #region Konstruktor
        private HoldPerson()
            : base(nameof(HoldPerson), 1100, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(LanguageEnum.Deutsch, "Person festhalten");
            Name.Set(LanguageEnum.English, "Hold person");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new HoldPerson());
        }
        #endregion
    }
}