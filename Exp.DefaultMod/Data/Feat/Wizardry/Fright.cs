using Exp.Data.Feat.Wizardry;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Wizardry
{
    public sealed class Fright : WizardryDataBase, IWizardryData {
        #region Konstruktor
        private Fright()
            : base(nameof(Fright), 500, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(LanguageEnum.Deutsch, "Schreck");
            Name.Set(LanguageEnum.English, "Fright");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Fright());
        }
        #endregion
    }
}