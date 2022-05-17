using Exp.Data.Feat.Wizardry;

namespace Exp.DefaultMod.Feat.Wizardry {
    public sealed class Metamagic : WizardryDataBase, IWizardryData {
        #region Konstruktor
        private Metamagic()
            : base(nameof(Metamagic), 1200, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two))) {
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