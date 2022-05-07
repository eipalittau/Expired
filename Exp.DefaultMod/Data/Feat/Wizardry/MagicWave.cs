namespace Exp.DefaultMod.Feat.Wizardry {
    public sealed class MagicWave : Exp.Data.Feat.WizardryDataBase, Exp.Data.Feat.IWizardryData {
        #region Konstruktor
        private MagicWave()
            : base(nameof(MagicWave), 100, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Magische Welle");
            Name.Set(Util.LanguageEnum.English, "Magic wave");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new MagicWave());
        }
        #endregion
    }
}