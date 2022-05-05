namespace Exp.DefaultMod.Feat.Wizardry {
    public sealed class Metamagic : Exp.Data.Feat.WizardryDataBase, Exp.Data.Feat.IWizardryData {
        #region Konstruktor
        private Metamagic()
            : base(nameof(Metamagic), 1200, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Metamagie");
            Name.Set(Util.LanguageEnum.English, "Metamagic");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Metamagic());
        }
        #endregion
    }
}