using Exp.Data.Feat.Wizardry;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Wizardry
{
    public sealed class MagicWave : WizardryDataBase, IWizardryData {
        #region Konstruktor
        private MagicWave()
            : base(nameof(MagicWave), 100, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(LanguageEnum.Deutsch, "Magische Welle");
            Name.Set(LanguageEnum.English, "Magic wave");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new MagicWave());
        }
        #endregion
    }
}