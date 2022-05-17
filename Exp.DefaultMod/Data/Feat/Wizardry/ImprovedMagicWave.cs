using Exp.Data.Feat.Wizardry;

namespace Exp.DefaultMod.Feat.Wizardry {
    public sealed class ImprovedMagicWave : WizardryDataBase, IWizardryData {
        #region Konstruktor
        private ImprovedMagicWave()
            : base(nameof(ImprovedMagicWave), 1300, 
                  Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), 
                  Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard)), 
                  Api.Feat.Wizardry.Singleton.Get(nameof(MagicWave))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Verbesserte magische Welle");
            Name.Set(Util.LanguageEnum.English, "Improved magic wave");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new ImprovedMagicWave());
        }
        #endregion
    }
}