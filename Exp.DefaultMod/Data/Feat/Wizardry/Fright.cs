namespace Exp.DefaultMod.Feat.Wizardry {
    public sealed class Fright : Exp.Data.Feat.WizardryDataBase, Exp.Data.Feat.IWizardryData {
        #region Konstruktor
        private Fright()
            : base(nameof(Fright), 500, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schreck");
            Name.Set(Util.LanguageEnum.English, "Fright");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Fright());
        }
        #endregion
    }
}