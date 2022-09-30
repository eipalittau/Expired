using Exp.Data.Feat.Wizardry;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Wizardry
{
    public sealed class Icicle : WizardryDataBase, IWizardryData {
        #region Konstruktor
        private Icicle()
            : base(nameof(Icicle), 900, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Move))) {
            Name.Set(LanguageEnum.Deutsch, "Eiszapfen");
            Name.Set(LanguageEnum.English, "Icicle");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Icicle());
        }
        #endregion
    }
}