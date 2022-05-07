namespace Exp.DefaultMod.Feat.Wizardry {
    public sealed class Reflection : Exp.Data.Feat.WizardryDataBase, Exp.Data.Feat.IWizardryData {
        #region Konstruktor
        private Reflection()
            : base(nameof(Reflection), 300, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Spiegelbild");
            Name.Set(Util.LanguageEnum.English, "Reflection");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Reflection());
        }
        #endregion
    }
}