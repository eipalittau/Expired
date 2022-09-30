using Exp.Data.Feat.Wizardry;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Wizardry
{
    public sealed class Shield : WizardryDataBase, IWizardryData {
        #region Konstruktor
        private Shield()
            : base(nameof(Shield), 400, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Free))) {
            Name.Set(LanguageEnum.Deutsch, "Schild");
            Name.Set(LanguageEnum.English, "Shield");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Shield());
        }
        #endregion
    }
}